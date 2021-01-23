using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            double fiyati = 15;
            string aciklama = "amasya elması";

            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = " amasya elması";

            Urun urun2 = new Urun();

            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            
            
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----");


            }

            Console.WriteLine("-----------------metodlar----------");


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            // class yerine bunu da kullanabiliriz ama class kök gibi değişimleri kökten değişmen
            //yetecek  ama bu yöntemle tek tek düzeltme yapmak zorunda kalırsın
            sepetManager.Ekle2("armut", "yeşil", 12);
            sepetManager.Ekle2("elma", "yeşil", 1);
            sepetManager.Ekle2("muz", "yerli", 10);
            // buna encapsulation denir.kapsülleme bir araya toplama





        }
    }
}



// tekrar tekrar kullanmayı sağlar
//do not repeat yourself - dry- clean code - best practice