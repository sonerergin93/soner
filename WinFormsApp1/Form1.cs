using System;
using System.Windows.Forms;
using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        FirmaKayitListesi firmaListesi = new FirmaKayitListesi();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string firmaAdi = txtFirmaAdi.Text.Trim();
            string adres = txtAdres.Text.Trim();
            string telefon = txtTelefon.Text.Trim();
            string webSitesi = txtWebSitesi.Text.Trim();
            string eposta = txtEposta.Text.Trim();

            if (!string.IsNullOrEmpty(firmaAdi) && !string.IsNullOrEmpty(adres) && !string.IsNullOrEmpty(telefon))
            {
                firmaListesi.FirmaEkle(firmaAdi, adres, telefon, webSitesi, eposta);
                MessageBox.Show("Firma baþarýyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen firma adý, adres ve telefon bilgilerini eksiksiz giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAra_Click(object sender, EventArgs e)
        {
            string arananFirma = txtArananFirma.Text.Trim();

            if (string.IsNullOrEmpty(arananFirma))
            {
                MessageBox.Show("Lütfen aramak istediðiniz firma adýný girin.");
                return;
            }

            FirmaKayit arananFirmaKayit = firmaListesi.FirmaAra(arananFirma);

            if (arananFirmaKayit == null)
            {
                MessageBox.Show("Aradýðýnýz firma bulunamadý.");
                return;
            }

            txtFirmaAdi.Text = arananFirmaKayit.FirmaAdi;
            txtTelefon.Text = arananFirmaKayit.Telefon;
            txtAdres.Text = arananFirmaKayit.Adres;
        }



        private void Temizle()
        {
            txtFirmaAdi.Clear();
            txtAdres.Clear();
            txtTelefon.Clear();
            txtEposta.Clear();
            txtWebSitesi.Clear();
         
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }

        private void btnAra_Click_1(object sender, EventArgs e)
        {

        }
    }
}

