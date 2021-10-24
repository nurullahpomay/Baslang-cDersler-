
 using System;

namespace BaslangıcDerslerı
{
    class Program
    {
        static void Main(string[] args)
        { // do not yourself--->kendini tekrar etme 
            string categoryEtiketPrice = "Kategoriler";
            int sayı = 1;
            // int,double(ondalıklı sayı verilerini tutar
            // ), ---> sayısal verirleri tutar
            //  bool --> true false değerlere göre programı dallandırılır
            bool sistemeGirişYapmışMı = true;
            double dolarDun = 7.35;
            double DolarBugun = 7.35;
             
            if (dolarDun > DolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (DolarBugun > dolarDun)
            {
                Console.WriteLine("yükseliş butonu");
            }
            else 
            {
                Console.WriteLine("eşittir butonu");
            }
            if (sistemeGirişYapmışMı== true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }

            


        }
    }
}
