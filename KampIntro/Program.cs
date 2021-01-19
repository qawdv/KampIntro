using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            string kategoriEtiketi = "Kategori";  // metinsel veri
            int ogrenciSayisi = 32000;  // Sayısal Veri
            double faizOrani = 1.45;   //ondalıklı sayı
            bool sistemeGirisYapmismi = true;  //iki durum giriş yapmışmı yapmamışmı
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Buotnu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }



            //  if () //şart 

            // { // şart geçerli ise buraya yazılır } 

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");

            }
            Console.WriteLine(kategoriEtiketi);





        }
    }
}
