using AltYapi.AraBirimler;
using AltYapi.Enumlar;
using AltYapi.Siniflar;
using System.ComponentModel;

namespace BankaGiseProjesi
{
    public partial class Form1 : Form
    {
        Banka banka = new Banka();

        public Form1()
        {
            InitializeComponent();
            cmbMusteriler.Items.Add("Müþteri Türü Seçiniz");
            cmbMusteriler.Items.AddRange(Enum.GetNames(typeof(MusteriTipi)));
            cmbMusteriler.SelectedIndex = 0;
            banka.Musteriler = new BindingList<IMusteri>();
            banka.Numarator = new Numarator();
            banka.Numarator.BekleyenMusteriler = new BindingList<IMusteri>();
        }

        private void cmbMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMusteriler.Items[0] == "Müþteri Türü Seçiniz" && cmbMusteriler.SelectedIndex != 0)
            {
                cmbMusteriler.Items.Remove(cmbMusteriler.Items[0]);
                btnEkle.Enabled = true;
                btnSiradaki.Enabled = true;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteri yeniMusteri = new Musteri();
            yeniMusteri.MusteriTuru = (MusteriTipi)Enum.Parse(typeof(MusteriTipi), cmbMusteriler.SelectedItem.ToString());
            yeniMusteri.TcKimlikNo = txtTcNo.Text;
            banka.Musteriler.Add(yeniMusteri);
            banka.Numarator.BekleyenMusteriler.Add(yeniMusteri);
            yeniMusteri.NumaratoreGit += banka.Numarator.NumaraUret;
            yeniMusteri.Numara = yeniMusteri.NumaraAL();
            ListeGuncelle(banka.Numarator.BekleyenMusteriler);
            //müþteri Listesini gridview a ekle.
            

        }

        private void ListeGuncelle(BindingList<IMusteri> liste)
        {
            dgvBekleyenler.DataSource = null;
            dgvBekleyenler.DataSource = liste;
        }

        private void btnSiradaki_Click(object sender, EventArgs e)
        {
            lblIslem.Text = banka.Numarator.SiradakiniGetir();
        }
    }
}