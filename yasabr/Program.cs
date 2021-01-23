using System;

namespace yasabr
{
    class Program
    {
        static void Main(string[] args)
        {
            string ayakkabiRengi = "kırmızı";

            switch ("ayakkabiRengi")

            {
                case "kırmızı":
                    Console.WriteLine("ayakkabıların kırmızı renk");
                    break;
                case "mor":
                    Console.WriteLine("ayakkabınız mor renk");
                    break;
                case "mavi":
                    Console.WriteLine("ayakkabınız mavi renk");
                    break;
                case "pembe":
                    Console.WriteLine("ayakkabınız pembe renk");
                    break;
                default:
                    Console.WriteLine("belirsiz renk");
                    break;
            }
    }
}
