using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SeminarskaNaloga.Modeli;
using SeminarskaNaloga.Podatki;

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
            var razredi = db.Poucevanja.Where(p => p.UporabnikId == profesor.Id).Select(p => p.Razred).Distinct().ToList();

            cbRazredi.DataSource = razredi;
            cbRazredi.DisplayMember = "Oddelek";
            cbRazredi.ValueMember = "Id";
        }

        private void LoadPredmeti()
        {
            using var db = new AppDbContext();
            var predmeti = db.Poucevanja.Where(p => p.UporabnikId == profesor.Id).Select(p => p.Predmet).Distinct().ToList();
        }

        private void cbRazredi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDijaki();
        }

        private void LoadDijaki()
        {
            if (cbRazredi.SelectedValue == null) return;

            int razredId = (int)cbRazredi.SelectedValue;
            using var db = new AppDbContext();

            dgvDijaki.DataSource = db.Dijaki.Where(d => d.RazredId == razredId).Select(d => new { d.Id, d.Ime, d.Priimek }).ToList();
        }

        private void btnDodajOceno_Click(object sender, EventArgs e)
        {
            if (dgvDijaki.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izberi dijaka!"); return;
            }

            int dijakId = (int)dgvDijaki.SelectedRows[0].Cells["Id"].Value;
            int poucevanjeId = GetPoucevanjeId(dijakId);

            using var db = new AppDbContext();
            db.Ocene.Add(new Ocena { DijakId = dijakId, PoucevanjeId = poucevanjeId, Vrednost = (int)nudOcena.Value });

            db.SaveChanges();

            MessageBox.Show("Ocena dodana!");
        }

        private int GetPoucevanjeId(int dijakId)
        {
            using var db = new AppDbContext();
            var razredId = db.Dijaki.Find(dijakId).RazredId;

            var poucevanje = db.Poucevanja.FirstOrDefault(p => p.RazredId == razredId && p.UporabnikId == profesor.Id);

            return poucevanje.Id;
        }
    }
}
