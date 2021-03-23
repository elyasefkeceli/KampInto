using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Products products)
        {
            Console.WriteLine("Urun sepete eklendi." + products.Adi);
        }
        public void Ekle2(string urunAdi,string aciklama , double fiyat,int stockAdedi)
        {
            Console.WriteLine("Urun sepete eklendi : "+ urunAdi);
        }
    }
}
