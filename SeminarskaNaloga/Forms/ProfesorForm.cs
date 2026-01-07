using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SeminarskaNaloga.Modeli;
using SeminarskaNaloga.Podatki;
using System.Linq;

namespace SeminarskaNaloga.Forms
{
    public partial class ProfesorForm : Form
    {
        private Uporabnik profesor;
        public ProfesorForm(Uporabnik u)
        {
            InitializeComponent();
            profesor = u;

            lblPozdrav.Text = $"Dobrodošel {u.UporabniskoIme}";

            // ensure grid refreshes when subject changes
            cbPredmeti.SelectedIndexChanged += (s, e) => LoadDijaki();

            LoadRazredi();
            LoadPredmeti();
        }

        private void LoadRazredi()
        {
            using var db = new AppDbContext();
            // load classes (razredi) — currently showing only those the professor teaches;
            // if you want all classes, change to db.Razredi.Select(...)
            var razredi = db.Poucevanja
                .Where(p => p.UporabnikId == profesor.Id)
                .Select(p => p.Razred)
                .Distinct()
                .Select(r => new { r.Id, Display = $"{r.Letnik}{r.Oddelek}" })
                .ToList();

            cbRazredi.DataSource = razredi;
            cbRazredi.DisplayMember = "Display";
            cbRazredi.ValueMember = "Id";

            if (cbRazredi.Items.Count > 0) cbRazredi.SelectedIndex = 0;
        }

        private void LoadPredmeti()
        {
            using var db = new AppDbContext();
            // load all subjects so professor can choose which subject's grades to view
            var predmeti = db.Predmeti
                .Select(pm => new { pm.Id, pm.Ime })
                .ToList();

            cbPredmeti.DisplayMember = "Ime";
            cbPredmeti.ValueMember = "Id";
            cbPredmeti.DataSource = predmeti;

            if (cbPredmeti.Items.Count > 0) cbPredmeti.SelectedIndex = 0;
        }

        private void cbRazredi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDijaki();
        }

        private void LoadDijaki()
        {
            if (cbRazredi.SelectedValue == null) return;
            if (!int.TryParse(cbRazredi.SelectedValue.ToString(), out int razredId)) return;

            int? predmetId = null;
            if (cbPredmeti.SelectedValue != null && int.TryParse(cbPredmeti.SelectedValue.ToString(), out int pid))
                predmetId = pid;

            using var db = new AppDbContext();

            // determine poucevanje (professor teaching the selected predmet for this razred)
            int? poucevanjeId = null;
            if (predmetId.HasValue)
            {
                var pv = db.Poucevanja
                    .FirstOrDefault(p => p.RazredId == razredId && p.UporabnikId == profesor.Id && p.PredmetId == predmetId.Value);
                if (pv != null) poucevanjeId = pv.Id;
            }

            // load students in the selected class
            var students = db.Dijaki
                .Where(d => d.RazredId == razredId)
                .Select(d => new { d.Id, d.Ime, d.Priimek })
                .ToList();

            string predmetIme = predmetId.HasValue ? db.Predmeti.Where(p => p.Id == predmetId.Value).Select(p => p.Ime).FirstOrDefault() ?? "" : "";

            // load all grades for those students and the poucevanje (if exists) in one query
            Dictionary<int, List<int>> gradesByStudent = new();
            if (poucevanjeId.HasValue && students.Count > 0)
            {
                var studentIds = students.Select(s => s.Id).ToList();
                var ocene = db.Ocene
                    .Where(o => o.PoucevanjeId == poucevanjeId.Value && studentIds.Contains(o.DijakId))
                    .Select(o => new { o.DijakId, o.Vrednost })
                    .ToList();

                gradesByStudent = ocene
                    .GroupBy(o => o.DijakId)
                    .ToDictionary(g => g.Key, g => g.Select(x => x.Vrednost).ToList());
            }

            // prepare rows: Id, Ime, Priimek, Predmet, Ocene (comma-separated)
            var rows = students.Select(s =>
            {
                gradesByStudent.TryGetValue(s.Id, out var vals);
                var oceneStr = (vals != null && vals.Count > 0) ? string.Join(", ", vals) : string.Empty;
                return new
                {
                    s.Id,
                    s.Ime,
                    s.Priimek,
                    Predmet = predmetIme,
                    Ocene = oceneStr
                };
            }).ToList();

            dgvDijaki.DataSource = rows;
        }

        private void btnDodajOceno_Click(object sender, EventArgs e)
        {
            if (dgvDijaki.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izberi dijaka!");
                return;
            }

            if (cbPredmeti.SelectedValue == null || cbRazredi.SelectedValue == null)
            {
                MessageBox.Show("Izberi razred in predmet.");
                return;
            }

            int dijakId = (int)dgvDijaki.SelectedRows[0].Cells["Id"].Value;
            int predmetId = Convert.ToInt32(cbPredmeti.SelectedValue);

            int poucevanjeId = GetPoucevanjeIdFor(dijakId, predmetId);

            if (poucevanjeId == 0)
            {
                MessageBox.Show("Ne najdem poučevanja za izbranega dijaka/profesorja/predmet.");
                return;
            }

            using var db = new AppDbContext();
            db.Ocene.Add(new Ocena { DijakId = dijakId, PoucevanjeId = poucevanjeId, Vrednost = (int)nudOcena.Value });
            db.SaveChanges();

            MessageBox.Show("Ocena dodana!");

            // refresh grid so the new grade appears
            LoadDijaki();
        }

        private int GetPoucevanjeIdFor(int dijakId, int predmetId)
        {
            using var db = new AppDbContext();
            var dijak = db.Dijaki.Find(dijakId);
            if (dijak == null) return 0;

            var poucevanje = db.Poucevanja
                .FirstOrDefault(p => p.RazredId == dijak.RazredId && p.UporabnikId == profesor.Id && p.PredmetId == predmetId);

            return poucevanje?.Id ?? 0;
        }
    }
}
