using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)

            //SAYUTLAMA
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Ersin";
            musteri1.Soyadi = "Sular";
            musteri1.TcNo = "1234556767";
            musteri1.Id = 1;


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "45345";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "124543673";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager;
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

        }
    }
}
