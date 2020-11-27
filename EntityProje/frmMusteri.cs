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
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
        }

        dbEntityUrunEntities db = new dbEntityUrunEntities();

        void Listele()
        {
            dgvMusteri.DataSource = (from x in db.tblMusteris.Where(x => x.Durum == true)
                                     select new
                                     {
                                         x.MusteriID,
                                         x.MusteriAd,
                                         x.MusteriSoyad,
                                         x.Sehir
                                     }).ToList();
        }

        private void frmMusteri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            tblMusteri t = new tblMusteri();
            t.MusteriAd = txtMusteriAd.Text;
            t.MusteriSoyad = txtMusteriSoyad.Text;
            t.Sehir = txtSehir.Text;
            t.Durum = true;
            db.tblMusteris.Add(t);
            db.SaveChanges();
            MessageBox.Show("Müşteri Bilgileri Başarılı Bir Şekilde Kaydedildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var musteri = db.tblMusteris.Find(id);
            musteri.Durum = false;
            db.SaveChanges();
            MessageBox.Show("Müşteri Bilgileri, Başarılı Bir Şekilde Silindi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var musteri = db.tblMusteris.Find(id);
            musteri.MusteriAd = txtMusteriAd.Text;
            musteri.MusteriSoyad = txtMusteriSoyad.Text;
            musteri.Sehir = txtSehir.Text;
            db.SaveChanges();
            MessageBox.Show("Müşteri Bilgileri Başarılı Bir Şekilde Kaydedildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }
    }
}
