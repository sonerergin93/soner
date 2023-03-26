namespace WinFormsApp1
{
    class Program
    {
        static void Main()
        {
            FirmaKayitListesi firmaListesi = new FirmaKayitListesi();

            Console.WriteLine("Firma bilgilerini giriniz:");
            Console.Write("Ad: ");
            string ad = Console.ReadLine();
            Console.Write("Adres: ");
            string adres = Console.ReadLine();
            Console.Write("Telefon: ");
            string telefon = Console.ReadLine();
            Console.Write("Web sitesi: ");
            string webSite = Console.ReadLine();
            Console.Write("E-posta: ");
            string email = Console.ReadLine();

            FirmaKayit yeniFirma = new FirmaKayit(ad, adres, telefon, webSite, email);
            firmaListesi.FirmaEkle(yeniFirma);

            Console.WriteLine("\nKaydedilen firma bilgileri:");
            Console.WriteLine(yeniFirma.ToString());

            Console.WriteLine("\nFirma arama:");
            Console.Write("Aranacak firma adý: ");
            string arananFirma = Console.ReadLine();
            FirmaKayit arananFirmaKayit = firmaListesi.FirmaAra(arananFirma);

            if (arananFirmaKayit != null)
            {
                Console.WriteLine("\nAranan firma bilgileri:");
                Console.WriteLine(arananFirmaKayit.ToString());
            }
            else
            {
                Console.WriteLine($"\n{arananFirma} adlý firma bulunamadý.");
            }
        }
    }

}