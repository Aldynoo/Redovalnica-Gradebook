using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SeminarskaNaloga
{
    public partial class ProfesorForm : Form
    {
        public ProfesorForm()
        {
            InitializeComponent();
        }

        private void ProfesorForm_Load(object sender, EventArgs e)
        {
            NaloziProfesorje();
        }
        private void NaloziProfesorje()
        {
            using var db = new AppDbContext();
            //dgvProfesor.DataSource = db.Profesorji.ToList();
        }

        private void btnDodajProfesorja_Click(object sender, EventArgs e)
        {
            DodajProfesorja prof = new DodajProfesorja();
            if (prof.ShowDialog() == DialogResult.OK)
            {
                NaloziProfesorje();
            }
        }

        private void dgvProfesor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // txtID.Text = dgvProfesor.Rows[e.RowIndex].Cells[0].Value.ToString();
            //txtPriIme.Text = dgvProfesor.Rows[e.RowIndex].Cells[1].Value.ToString();
            //txtPredmet.Text = dgvProfesor.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txtRazred.Text = dgvProfesor.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }
    }
}
