using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_banka_denemesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("furkaneno");

            /*

            DateTime anlik = DateTime.Now;
            Console.WriteLine(anlik);

            DateTime bugun = DateTime.Today;
            Console.WriteLine(bugun);


            DateTime sekiz = new DateTime(2017, 11, 10, 9, 5, 0);
            Console.WriteLine(sekiz);

            */



            Console.WriteLine("**********");


            DateTime saat = new DateTime(2022, 10, 15, 8, 0, 0);

            Console.WriteLine(saat);

            Queue<int> sira = new Queue<int>();


            for (int i = 1; i <= 100; i++)
            {
                sira.Enqueue(i);

            }

            Console.WriteLine("*********");


            Random bekleme = new Random();
            Random islem = new Random();

            int beklemesuresi = bekleme.Next(1, 9);
            int islemsuresi = islem.Next(1, 10);


            for (int i = 1; i <= 100; i += 2)
            {

                Console.WriteLine(i + ".kisi gise 1' de");

                Console.Write(i + ".kisinin bekleme suresi = ");
                Console.WriteLine(beklemesuresi = bekleme.Next(1, 9));

                Console.Write(i + ".kisinin islem suresi = ");
                Console.WriteLine(islemsuresi = islem.Next(1, 10));

                int azalan = beklemesuresi + islemsuresi;
                Console.WriteLine(azalan);

                DateTime yenisaat = saat.AddMinutes(azalan);
                Console.WriteLine(yenisaat);

                yenisaat = saat.AddMinutes(-azalan);

                Console.WriteLine();

                Console.WriteLine(i + 1 + ".kisi gise 2' de");

                Console.Write(i + 1 + ".kisinin bekleme suresi = ");
                Console.WriteLine(beklemesuresi = bekleme.Next(1, 9));

                Console.Write(i + 1 + ".kisinin islem suresi = ");
                Console.WriteLine(islemsuresi = islem.Next(1, 10));

                azalan = beklemesuresi + islemsuresi;

                yenisaat = saat.AddMinutes(azalan);
                Console.WriteLine(yenisaat);


                List<int> gise2 = new List<int>();

                gise2.Add(i + 1);


                saat = yenisaat;

                List<int> gise1 = new List<int>();

                gise1.Add(i);

                Console.WriteLine();

                sira.Dequeue();


            }




            Console.ReadKey();
        }
    }
}