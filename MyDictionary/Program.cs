using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> Ogrenci = new MyDictionary<string, string>();

            Ogrenci.Add("334","Ersin");

            Ogrenci.Add("376", "Şenol");
            Ogrenci.Add("992", "Cemile");
            Ogrenci.Add("222", "Kaan");
            // Console.WriteLine(Ogrenci.MyLength);



            Ogrenci.PrintAll();

            //Console.WriteLine(Ogrenci.Count);

            for (int a = 0; a < Ogrenci.MyLength; a++)
            {
                Console.WriteLine(Ogrenci.Items1[a] + " " + Ogrenci.Items2[a]);
            }

            
        }
    }
}
