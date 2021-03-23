using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products();
            product1.Adi = "elma";
            product1.Aciklama = "yesil elma";
            product1.Fiyati = 5;

            Products product2 = new Products();
            product2.Adi = "armut";
            product2.Aciklama = "yesil armut";
            product2.Fiyati = 7;

            Products product3 = new Products();
            product3.Adi = "karpuz";
            product3.Aciklama = "diyarbakir karpuz";
            product3.Fiyati = 22;

            Products[] products = new Products[] { product1, product2, product3 };

            foreach (Products product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine("------------");
            }
            Console.WriteLine("------Methods-----");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle(product3);
            sepetManager.Ekle2("fındık","çakıl fındık",25,30000);
        }
    }
}
