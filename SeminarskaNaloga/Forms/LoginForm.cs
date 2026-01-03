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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            lblSporocilo.Text = "";

            if (string.IsNullOrWhiteSpace(txtUporabnik.Text) || string.IsNullOrWhiteSpace(txtGeslo.Text))
            {
                lblSporocilo.Text = "Vnesi uporabniško ime in geslo!";
                return;
            }

            using (var db = new AppDbContext())
            {
                var uporabnik = db.Uporabniki.FirstOrDefault(u => u.UporabniskoIme == txtUporabnik.Text && u.Geslo == txtGeslo.Text);

                if (uporabnik == null)
                {
                    lblSporocilo.Text = "Napačno uporabniško ime ali geslo!";
                    return;
                }

                this.Hide();
                if (uporabnik.Vloga == "admin")
                {
                    new AdminForm().Show();
                }
                else if (uporabnik.Vloga == "profesor")
                {
                    new ProfesorForm(uporabnik).Show();
                }
            }
        }
        private void btnIzhod_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
