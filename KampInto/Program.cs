using System;

namespace KampInto
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Elyase";
            int yas = 25;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "java";
            kurs1.Egitmen = "Faruk";
            kurs1.izlenmeOranı = 33;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "python";
            kurs2.Egitmen = "Fatih";
            kurs2.izlenmeOranı = 22;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C#";
            kurs3.Egitmen = "Elyase";
            kurs3.izlenmeOranı = 44;

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine("kurs Adı :" +kurs.KursAdi +" --"+ " : "+"kurs Egitmeni : "+ kurs.Egitmen +"--"+ "kurs izlenme sayisi : "+ kurs.izlenmeOranı);
            }
        }
        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int izlenmeOranı { get; set; }

        }
    }
}
