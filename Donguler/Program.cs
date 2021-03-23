using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array-dizi
            string[] kurslar = new string[] { "yazilim gelistirme kursu", "programlama başlamak için temel kurs", "java","python"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("--------------");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu- footer");
        }
    }
}
