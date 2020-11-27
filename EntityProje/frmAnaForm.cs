using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProje
{
    public partial class frmAnaForm : Form
    {
        public frmAnaForm()
        {
            InitializeComponent();
        }

        private void btnKategoriIslemleri_Click(object sender, EventArgs e)
        {
            frmKategori fr = new frmKategori();
            fr.ShowDialog();
        }

        private void btnUrunIslemleri_Click(object sender, EventArgs e)
        {
            frmUrun fr = new frmUrun();
            fr.ShowDialog();
        }

        private void btnIstatistikler_Click(object sender, EventArgs e)
        {
            frmIstatistikler fr = new frmIstatistikler();
            fr.ShowDialog();
        }
    }
}
