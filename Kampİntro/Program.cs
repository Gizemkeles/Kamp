using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {


            double dolarDun = 7.95;
            double dolarBugun = 7.95;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu"); 
            }

            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "java";

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", "programlamaya başlangıç için temel kurs", "java" ,"Python","C++"};

            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("sayfa sonu - footer");

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }











        }

    }
}
