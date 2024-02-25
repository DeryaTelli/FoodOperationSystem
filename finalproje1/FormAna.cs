using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace finalproje1
{
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

        private void formBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void foToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void formCToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void formAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKullaniciGiris kullaniciGiris = new FormKullaniciGiris();
            kullaniciGiris.MdiParent=this;
            kullaniciGiris.Show();

        }

        private void FormAna_Load(object sender, EventArgs e)
        {

        }
    }
}
