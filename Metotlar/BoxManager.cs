using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class BoxManager
    {
        //naming convention
        //syntax
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler ürününüz başarıyla sepete eklendi!!" + urun.Adi);

        }

        public void Ekle2(string urunAdi,string Açıklama,double Fiyat)
        {
            Console.WriteLine("Tebrikler ürününüz başarıyla sepete eklendi!!" + urun.Adi);
        }
    }
}
