using System;

namespace _2.ders4.odev
{
    class Program
    {
         public static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.urunAdi = "kazak";
            urun1.urunAdedi = 2;
            urun1.urunBedeni = "m";

            Urun urun2 = new Urun();
            urun2.urunAdi = "etek";
            urun2.urunAdedi = 3;
            urun2.urunBedeni = "s";

            Urun urun3 = new Urun();
            urun3.urunAdi = "mont";
            urun3.urunAdedi = 10;
            urun3.urunBedeni = "xl";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("urun adı: " + urun.urunAdi);
            }






        }
    }
    class Urun {
        public string urunAdi { get; set; }
        public int urunAdedi { get; set; }
        public string urunBedeni { get; set; }
    }
}
