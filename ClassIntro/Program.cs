using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.egitmen = "engin";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "python";
            kurs2.egitmen = "enginer";
            kurs2.izlenmeOrani = 78;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "java";
            kurs3.egitmen = "zengin";
            kurs3.izlenmeOrani = 58;


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + ":" + kurs.egitmen);
            }





        }
    }
    

    class Kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOrani { get; set; }


      

    }

   








}
