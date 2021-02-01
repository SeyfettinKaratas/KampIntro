using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            string kategoriEtiketi = "kategori";

            Console.WriteLine("kategoriEtiketi");

            int öğrencisayısı = 32000;
            double faizoranı = 1.45;

            bool sistemegirişyaptımı = false;

            double dolardun = 7.35;
            double dolarbugun = 7.45;

            if (dolardun > dolarbugun) { Console.WriteLine("azalış butonu"); }
            else if(dolardun<dolarbugun) { Console.WriteLine("artış butonu"); }
            else
            {
                Console.WriteLine("değişmedi");
            }

            if (sistemegirişyaptımı ==true)
            { Console.WriteLine("kullanıcı ayar butonu"); }
            else 
            { Console.WriteLine("giriş yap butonu"); }



        }
    }
}
