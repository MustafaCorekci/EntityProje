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
    public partial class frmIstatistikler : Form
    {
        public frmIstatistikler()
        {
            InitializeComponent();
        }

        dbEntityUrunEntities db = new dbEntityUrunEntities();

        private void frmIstatistikler_Load(object sender, EventArgs e)
        {
            lblToplamKategori.Text = db.tblKategoris.Count().ToString();
            lblToplamUrun.Text = db.tblUruns.Count().ToString();
            lblAktifMusteri.Text = db.tblMusteris.Count(x => x.Durum == true).ToString();
            lblPasifMusteri.Text = db.tblMusteris.Count(x => x.Durum == false).ToString();
            lblToplamStok.Text = db.tblUruns.Sum(y => y.Stok).ToString();
            lblKasadakiTutar.Text = db.tblSatis.Sum(z => z.Fiyat).ToString() + " TL";
            lblEnYuksekFiyatliUrun.Text = (from x in db.tblUruns orderby x.Fiyat descending select x.UrunAd).FirstOrDefault();
            lblEnDusukFiyatliUrun.Text = (from x in db.tblUruns orderby x.Fiyat ascending select x.UrunAd).FirstOrDefault();
            lblToplamBeyazEsya.Text = db.tblUruns.Count(x => x.Kategori == 1).ToString();
            lblBuzdolabiSayisi.Text = db.tblUruns.Count(x => x.UrunAd == "Buzdolabı").ToString();
            lblSehirSayisi.Text = (from x in db.tblMusteris select x.Sehir).Distinct().Count().ToString();
            lblEnFazlaUrunluMarka.Text = db.MarkaGetir().FirstOrDefault();
        }
    }
}
