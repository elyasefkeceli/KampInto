using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int Toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuc :" + Toplam);
        }
        public void Cıkar(int sayi1,int sayi2) 
        {
            int Cıkar = sayi1 - sayi2;
            Console.WriteLine("Sonuc :" + Cıkar);
        }
        public void Carp(double sayi1, double sayi2)
        {
            double Carp = sayi1 * sayi2;
            Console.WriteLine("Sonuc :"+ Carp);
        }
        public void Bol(double sayi1,double sayi2)
        {
            double Bol = sayi1 / sayi2;
            Console.WriteLine("Toplam :" + Bol);
        }
    }
}
