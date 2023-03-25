using System;

namespace sınıflar
{
    class Program
    {
        static void Main(string[] args)
        {
            //söz dizimi
            //class sinifadi
            // {
            //     [Erişim Belirleyici] [Veri Tipi] Özellik Adı;
            //     [Erişim Belirleyici] [Geri Dönüş Tipi] Metot Adı([Parametre Listesi]);
            //     {
            //         Metot Komutları
            //     }
            // }

            // Erişim Belirleyiciler
            // Public
            // Private
            // İnternal
            // Protected
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Elvan";
            calisan1.Soyad = "Tektaş";
            calisan1.No = 65748596;
            calisan1.Departman = "Yazılım Geliştirici";

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Zeynep";
            calisan2.Soyad = "Tektaş";
            calisan2.No = 2132343657;
            calisan2.Departman = "İnsan Kaynakları";

            calisan2.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", No);
            Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
        }
    }
}
