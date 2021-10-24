using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        { //bu aşşakdaki kodu ürün veri tipinde bir değer tutucu oluşturduk
            Urun urun1 = new Urun();
            urun1.Adı = "elma";
            urun1.Fıyatı = 15;
            urun1.Acıklama = "amsaya elması";

            Urun urun2 = new Urun();
            urun2.Adı = "karpuz";
            urun2.Fıyatı = 80;
            urun2.Acıklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach ( Urun urun in urunler)
            {
                Console.WriteLine(urun.Adı);
                Console.WriteLine(urun.Fıyatı);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine("--------------");
            }
            Console.WriteLine("--------metotlar------");
            // instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.add(urun1);
            sepetManager.add(urun2);

            







        }
    }
}
