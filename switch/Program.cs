using System;

namespace switch
{
    class Program
{
    static void Main(string[] args)
    {
        int gunler = 5;
        switch (gunler)
        {
            case 1:
                Console.WriteLine("pazartesi");
                break;
            case 2:
                Console.WriteLine("salı");
                break;
            case 3:
                Console.WriteLine("çarşamba");
                break;
            case 4:
                Console.WriteLine("perşembe");
                break;
            case 5:
                Console.WriteLine("cuma");
                break;
            case 6:
                Console.WriteLine("cumartesi");
                break;
            case 7:
                Console.WriteLine("pazar");
                break;
            default:
                Console.WriteLine("hatalı giriş");
                break;
        }
    }
}
}
