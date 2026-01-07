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
            LoadRazredi();
            LoadPredmeti();
        }

        private void LoadRazredi()
        {
            using var db = new AppDbContext();
            var razredi = db.Poucevanja
                .Where(p => p.UporabnikId == profesor.Id)
                .Select(p => p.Razred)
                .Distinct()
                .Select(r => new { r.Id, Display = $"{r.Letnik}{r.Oddelek}" })
                .ToList();

            cbRazredi.DataSource = razredi;
            cbRazredi.DisplayMember = "Display";
            cbRazredi.ValueMember = "Id";
        }

        private void LoadPredmeti()
        {
            using var db = new AppDbContext();
            var predmeti = db.Poucevanja
                .Where(p => p.UporabnikId == profesor.Id)
                .Select(p => p.Predmet)
                .Distinct()
                .Select(pm => new { pm.Id, pm.Ime })
                .ToList();

            cbPredmeti.DataSource = predmeti;
            cbPredmeti.DisplayMember = "Ime";
            cbPredmeti.ValueMember = "Id";
        }

        private void cbRazredi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDijaki();
        }

        private void LoadDijaki()
        {
            if (cbRazredi.SelectedValue == null) return;

            int razredId;
            try
            {
                razredId = Convert.ToInt32(cbRazredi.SelectedValue);
            }
            catch
            {
                return;
            }

            using var db = new AppDbContext();

            dgvDijaki.DataSource = db.Dijaki
                .Where(d => d.RazredId == razredId)
                .Select(d => new { d.Id, d.Ime, d.Priimek })
                .ToList();
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
