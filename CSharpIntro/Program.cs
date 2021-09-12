using System;

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boolean veri tipi uygulamalrımızı dallandırmak için kulandığımız veri tipidir.

            bool deger = true;
            double piyasaDun = 115000.6;
            double piyasaBugun = 116000;
            bool sonuc = piyasaBugun > piyasaDun;

            if (sonuc == true)
            {
                Console.WriteLine("Artış Oku");
            }



            int aboneSayisi = 34000;
            Console.WriteLine("Hello World!");
        }
    }
}
