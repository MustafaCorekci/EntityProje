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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            dbEntityUrunEntities db = new dbEntityUrunEntities();

            var sorgu = from x in db.tblAdmins where x.Kullanici == txtKullanici.Text && x.Sifre == txtSifre.Text select x;
            if (sorgu.Any())
            {
                frmAnaForm fr = new frmAnaForm();
                this.Hide();
                fr.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Yada Şifre Hatalı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
