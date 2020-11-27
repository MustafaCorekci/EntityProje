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
    public partial class frmUrun : Form
    {
        public frmUrun()
        {
            InitializeComponent();
        }

        dbEntityUrunEntities db = new dbEntityUrunEntities();

        void Listele()
        {
            dgvUrun.DataSource = (from x in db.tblUruns
                                  select new
                                  {
                                      x.UrunID,
                                      x.UrunAd,
                                      x.Marka,
                                      x.Stok,
                                      x.Fiyat,
                                      x.tblKategori.KategoriAd,
                                      x.Durum
                                  }).ToList();
        }

        private void frmUrun_Load(object sender, EventArgs e)
        {
            Listele();

            var kategoriler = (from x in db.tblKategoris
                               select new
                               {
                                   x.ID,
                                   x.KategoriAd
                               }
                               ).ToList();
            cmbKategori.ValueMember = "ID";
            cmbKategori.DisplayMember = "KategoriAd";
            cmbKategori.DataSource = kategoriler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            tblUrun t = new tblUrun();
            t.UrunAd = txtUrunAd.Text;
            t.Marka = txtMarka.Text;
            t.Stok = short.Parse(txtStok.Text);
            t.Kategori = int.Parse(cmbKategori.SelectedValue.ToString());
            t.Fiyat = decimal.Parse(txtFiyat.Text);
            t.Durum = true;
            db.tblUruns.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Sisteme Başarılı Bir Şekilde Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var Urun = db.tblUruns.Find(id);
            db.tblUruns.Remove(Urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Sistemden Başarılı Bir Şekilde Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var Urun = db.tblUruns.Find(id);
            Urun.UrunAd = txtUrunAd.Text;
            Urun.Marka = txtMarka.Text;
            Urun.Stok = short.Parse(txtStok.Text);
            Urun.Kategori = int.Parse(cmbKategori.SelectedValue.ToString());
            Urun.Fiyat = decimal.Parse(txtFiyat.Text);
            Urun.Durum = true;
            db.SaveChanges();
            MessageBox.Show("Ürün Başarılı Bir Şekilde Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }
    }
}
