using System;

namespace ClassIntro_
{
    class Program
    {
        static void Main(string[] args)
        {
            string adı = "nurullah";
            int yas = 20;

            kurs kurs1 = new kurs();
            kurs1.egitmen = "engin demiroğ";
            kurs1.kursadı = "c#";
            kurs1.IzlenmeOranı = 85;

            kurs kurs2 = new kurs();
            kurs2.egitmen = "kerem";
            kurs2.kursadı = "java";
            kurs2.IzlenmeOranı = 64;

            kurs kurs3 = new kurs();
            kurs3.egitmen = "engin demiroğ";
            kurs3.kursadı = "pyton";
            kurs3.IzlenmeOranı = 58;

            kurs kurs4 = new kurs();
            kurs4.egitmen = "murat kurtay";
            kurs4.kursadı = "c++";
            kurs4.IzlenmeOranı = 100;

            //Console.WriteLine(kurs1.kursadı +"   :   "+ kurs1.egitmen);
            kurs[] kurslar = new kurs[]
            {
                kurs1,kurs2,kurs3,kurs4
            };
            foreach (var kurs in kurslar)
            {
                // bunlar gerçek haytta veri tabalarından gelecek

                
                Console.WriteLine(kurs.kursadı+ "   :   "+ kurs.egitmen);

            }

            // burada class yardımı ile kendi veri tiplerini olusturuyoruz....(önemli)
        }

        class kurs
        {
            //burada sanki kendi veri tipini oluşturuyoruz sen anladın nurullah bu notu okuduğunda aklına ne gelecek şimdi geldimi gelmediyse c# temelleri 2. vidyo
            public string kursadı { get; set; }
            public string egitmen { get; set; }
            public int IzlenmeOranı { get; set; }

        }
         
    }
}
