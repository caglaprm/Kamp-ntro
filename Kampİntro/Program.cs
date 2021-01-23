using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketi = "kategori" ;
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = false;

            double dolarDun = 7.35;
            double dolarBugun = 7.25;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu");

            }
            else
            {
                Console.WriteLine("eşittir");
            }

            if (sistemeGirisYapmisMi == true)
            {    Console.WriteLine("kullanıcı ayarlar butonu");
           

            }

            else
            {
                Console.WriteLine("giriş yap butonu");
            }

            Console.WriteLine("KategoriEtiketi");
            






        }
    }
}
