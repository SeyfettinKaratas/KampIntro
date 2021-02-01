using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Product urun1 = new Product();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Açıklama = "amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Açıklama = "diyarbakır karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };

            //type safe
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Açıklama);
                Console.WriteLine("----------------------");

            }

            Console.WriteLine("---------------Metotlar------------");


            //Class instance--örnek
            BoxManager boxManager = new BoxManager();
            boxManager.Ekle(urun1);
            boxManager.Ekle(urun2);
            //encapsulation
            boxManager.Ekle2("armut", "yeşil", 12);
           
        }
    }
}



