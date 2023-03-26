using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class FirmaKayitListesi
    {
        private List<FirmaKayit> firmaListesi = new List<FirmaKayit>();

        public void FirmaEkle(string firmaAdi, string adres, string telefon, string webSitesi, string eposta)
        {
            FirmaKayit firmaKayit = new FirmaKayit(firmaAdi, adres, telefon, webSitesi, eposta);
            firmaListesi.Add(firmaKayit);
        }


        public List<FirmaKayit> FirmaListesiAl()
        {
            return firmaListesi;
        }

        public FirmaKayit FirmaAra(string firmaAdi)
        {
            foreach (FirmaKayit firma in firmaListesi)
            {
                if (firma.ad == firmaAdi)
                {
                    return firma;
                }
            }
            return null;
        }
    }

}
