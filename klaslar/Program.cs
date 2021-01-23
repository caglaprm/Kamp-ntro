using System;

namespace klaslar
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yasi = 36;

            kurs kurs1 = new kurs();
              kurs1.kursAdi = "c#";
              kurs1.eğitmen = "engin demiroğ";
              kurs1.izlenmeOrani = 68;

            kurs kurs2 = new kurs();
              kurs2.eğitmen = "kerem variş";
              kurs2.kursAdi = "java";
              kurs2.izlenmeOrani = 69;

            kurs kurs3 = new kurs();
              kurs3.eğitmen = "berkay bilgin";
              kurs3.izlenmeOrani = 65;
              kurs3.kursAdi = "pyhton";

            kurs kurs4 = new kurs();
            kurs4.eğitmen = "murat kurtboğan";
            kurs4.kursAdi = "c++";
            kurs4.izlenmeOrani = 100;

              

            //Console.WriteLine(kurs1.kursAdi + " " + kurs1.eğitmen);

            kurs[] kurslar = new kurs[] { kurs1 , kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " : " + kurs.eğitmen);
            }

            
        }
    }

    class kurs
    {
        public string kursAdi { get; set; }
        public string eğitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
}


