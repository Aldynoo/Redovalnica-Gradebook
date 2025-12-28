using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace SeminarskaNaloga
{
    public partial class frmRedovalnica : Form
    {
        public frmRedovalnica()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            MeniForm mf = new MeniForm();
            mf.ShowDialog();
        }
    }
}
