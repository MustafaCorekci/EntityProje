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
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }

        dbEntityUrunEntities db = new dbEntityUrunEntities();

        void Listele()
        {
            dataGridView1.DataSource = (from x in db.tblKategoris
                                        select new
                                        {
                                            x.ID,
                                            x.KategoriAd
                                        }).ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            tblKategori k = new tblKategori();
            k.KategoriAd = txtKategoriAd.Text;
            db.tblKategoris.Add(k);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtKategoriID.Text);
            var ktgr = db.tblKategoris.Find(x);
            db.tblKategoris.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Silindi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtKategoriID.Text);
            var ktgr = db.tblKategoris.Find(x);
            ktgr.KategoriAd = txtKategoriAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Listele();
        }
    }
}
