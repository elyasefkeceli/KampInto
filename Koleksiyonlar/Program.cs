using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "elyase", "faruk", "furkan", "fatih" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            List<string> isimler2 = new List<string> {"elyase","faruk","furkan","fatih" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            Console.WriteLine("--------------");
            List<string> isimler3 = new List<string> { "ayşe","fatma","betül","gamze"};
            Console.WriteLine(isimler3[0]);
            Console.WriteLine(isimler3[3]);
            isimler3.Add("huriye");
            Console.WriteLine(isimler3[4]);
        }
    }
}
