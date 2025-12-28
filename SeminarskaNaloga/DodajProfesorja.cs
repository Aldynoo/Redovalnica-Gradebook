using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace SeminarskaNaloga
{
    public partial class DodajProfesorja : Form
    {
        public DodajProfesorja()
        {
            InitializeComponent();
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            db.Profesorji.Add(new Profesor { PriIme = txtPriIme.Text });
            db.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void DodajProfesorja_Load(object sender, EventArgs e)
        {
         
        }
    }
}
