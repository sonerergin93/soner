using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class FirmaKayit
    {
        public string ad;
        public string adres;
        public string telefon;
        public string webSite;
        public string email;
        internal string FirmaAdi;
        internal string Telefon;

        public string Adres { get; set; }

        public FirmaKayit(string ad, string adres, string telefon, string webSite, string email)
        {
            this.ad = ad;
            this.adres = adres;
            this.telefon = telefon;
            this.webSite = webSite;
            this.email = email;
        }

        public override string ToString()
        {
            return $"Firma adı: {ad}\nAdres: {adres}\nTelefon: {telefon}\nWeb sitesi: {webSite}\nE-posta: {email}";
        }
    }

}
