using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SeminarskaNaloga.Podatki;
using SeminarskaNaloga.Modeli;

namespace SeminarskaNaloga.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            LoadRazredi();
            LoadDijaki();
        }

        private void LoadRazredi()
        {
            using var db = new AppDbContext();
            cbRazredi.DataSource = db.Razredi.Select(r => new { r.Id, Display = $"{r.Letnik}{r.Oddelek}" }).ToList();
            cbRazredi.DisplayMember = "Display";
            cbRazredi.ValueMember = "Id";
        }

        private void LoadDijaki()
        {
            using var db = new AppDbContext();
            dgvDijaki.DataSource = db.Dijaki.Select(d => new
            {
                d.Id,
                d.Ime,
                d.Priimek,
                d.Naslov,
                d.Telefon,
                Razred = d.Razred.Letnik + d.Razred.Oddelek
            }).ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text) || string.IsNullOrWhiteSpace(txtPriimek.Text))
            {
                MessageBox.Show("Ime in priimek sta obvezna!");
                return;
            }

            using var db = new AppDbContext();
            var dijak = new Dijak
            {
                Ime = txtIme.Text,
                Priimek = txtPriimek.Text,
                Naslov = txtNaslov.Text,
                Telefon = txtTelefon.Text,
                RazredId = (int)cbRazredi.SelectedValue
            };
            db.Dijaki.Add(dijak);
            db.SaveChanges();

            MessageBox.Show("Dijak dodan!");
            LoadDijaki();

            txtIme.Text = "";
            txtPriimek.Text = "";
            txtNaslov.Text = "";
            txtTelefon.Text = "";
        }
    }
}
