using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // mototlar bu şekilde yazılır
        // eğer bir yerde normal prantez "()" görürsen orada meto çalışıyor demektir
        public void add( Urun urun ) // "Urun urun" parametredir 
        {
            Console.WriteLine("sepete eklendi : "+ urun.Adı);
        }
       

    }
}
