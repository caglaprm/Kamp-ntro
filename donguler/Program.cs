using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kampı";
            string kurs2 = "proglanmaya başlangıç için temel kurs";
            string kurs3 = "java";
            string kurs4 = "python";
            string kurs5 = "c#";


            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);
 

            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı"
                ,"proglanmaya başlangıç için temel kurs","java","pyhton", "c#" };


              for (int i = 0; i<kurslar.Length; i++)
            { 
               Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            //foreach (string kurs in kurslar)
            {
                //Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu-footer");
            
          
        }

    
    }
}
