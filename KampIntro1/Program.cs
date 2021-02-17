using System;

namespace KampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            //Do not repeat yourself - kendini tekrarlama
            //değer tutucu, alias = kategoriEtiketi

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmişmi = false;
            double dolarınDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarınDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu göster");
            }
            else if (dolarınDun<dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            
            if (sistemeGirisYapmişmi == true)
            {
                Console.WriteLine("Kullanıcı ayarı butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);

        }
    }
}
