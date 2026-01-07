using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SeminarskaNaloga.Podatki;
using SeminarskaNaloga.Modeli;
using System.Linq;

namespace SeminarskaNaloga.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            LoadRazredi();
            LoadDijaki();
            LoadProfesorji();
            LoadPredmetiForProf();
            btnDodajProf.Click += btnDodajProf_Click;
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

            if (cbRazredi.SelectedItem == null)
            {
                MessageBox.Show("Izberite razred!");
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

        private void LoadProfesorji()
        {
            using var db = new AppDbContext();
            var profs = db.Uporabniki
                .Where(u => u.Vloga == "profesor")
                .Select(u => new
                {
                    u.Id,
                    u.Ime,
                    u.Priimek,
                    u.Telefon,
                    Predmet = db.Poucevanja.Where(p => p.UporabnikId == u.Id).Select(p => p.Predmet.Ime).FirstOrDefault()
                })
                .ToList();

            dgvProfesorji.AutoGenerateColumns = false;
            dgvProfesorji.Columns.Clear();

            dgvProfesorji.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                DataPropertyName = "Id",
                Visible = false
            });

            dgvProfesorji.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ime",
                DataPropertyName = "Ime",
                Name = "Ime"
            });

            dgvProfesorji.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Priimek",
                DataPropertyName = "Priimek",
                Name = "Priimek"
            });

            dgvProfesorji.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Telefon",
                DataPropertyName = "Telefon",
                Name = "Telefon"
            });

            dgvProfesorji.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Predmet",
                DataPropertyName = "Predmet",
                Name = "Predmet"
            });

            dgvProfesorji.DataSource = profs;
        }

        private void LoadPredmetiForProf()
        {
            using var db = new AppDbContext();
            var predmeti = db.Predmeti
                .Select(p => new { p.Id, p.Ime })
                .ToList();

            if (predmeti.Count == 0)
            {
                MessageBox.Show("Nič najdeno  v db.", "Debug");
            }

            cbPredmetProf.DisplayMember = "Ime";
            cbPredmetProf.ValueMember = "Id";
            cbPredmetProf.DataSource = predmeti;

            if (cbPredmetProf.Items.Count > 0)
                cbPredmetProf.SelectedIndex = 0;
        }

        private void btnDodajProf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImeProf.Text) || string.IsNullOrWhiteSpace(txtPriimekProf.Text))
            {
                MessageBox.Show("Ime in priimek profesorja sta obvezna!");
                return;
            }

            if (cbPredmetProf.SelectedValue == null)
            {
                MessageBox.Show("Izberite predmet za profesorja!");
                return;
            }

            int predmetId;
            try
            {
                predmetId = Convert.ToInt32(cbPredmetProf.SelectedValue);
            }
            catch
            {
                MessageBox.Show("Neveljaven predmet.");
                return;
            }

            CreateProfesor(txtImeProf.Text.Trim(), txtPriimekProf.Text.Trim(), txtTelefonProf.Text.Trim(), predmetId);

            txtImeProf.Text = "";
            txtPriimekProf.Text = "";
            txtTelefonProf.Text = "";
            if (cbPredmetProf.Items.Count > 0)
                cbPredmetProf.SelectedIndex = 0;
        }

        public void CreateProfesor(string ime, string priimek, string telefon, int predmetId)
        {
            if (string.IsNullOrWhiteSpace(ime) || string.IsNullOrWhiteSpace(priimek))
            {
                MessageBox.Show("Ime in priimek sta obvezna!");
                return;
            }

            using var db = new AppDbContext();
            string baseUser = $"{ime}.{priimek}".ToLowerInvariant().Replace(" ", "");
            string username = baseUser;
            int suffix = 1;
            while (db.Uporabniki.Any(u => u.UporabniskoIme == username))
            {
                username = $"{baseUser}{suffix}";
                suffix++;
            }

            var rnd = new Random();
            string password = $"prof{rnd.Next(1000, 10000)}";

            var uporabnik = new Uporabnik
            {
                UporabniskoIme = username,
                Geslo = password,
                Vloga = "profesor",
                Ime = ime,
                Priimek = priimek,
                Telefon = telefon
            };

            db.Uporabniki.Add(uporabnik);
            db.SaveChanges();

            var allRazredi = db.Razredi.ToList();
            foreach (var r in allRazredi)
            {
                db.Poucevanja.Add(new Poucevanje
                {
                    UporabnikId = uporabnik.Id,
                    RazredId = r.Id,
                    PredmetId = predmetId
                });
            }
            db.SaveChanges();

            LoadProfesorji();

            MessageBox.Show($"Profesor ustvarjen.\nUporabniško ime: {username}\nGeslo: {password}", "Profesor dodan");
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
