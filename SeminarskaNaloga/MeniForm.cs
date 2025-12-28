using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SeminarskaNaloga
{
    public partial class MeniForm : Form
    {
        public MeniForm()
        {
            InitializeComponent();
        }

        private void btnProfesorji_Click(object sender, EventArgs e)
        {
            ProfesorForm pf = new ProfesorForm();
            pf.ShowDialog();
        }
    }
}
