using System;
using System.Collections.Generic;

namespace GenericsInto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyList<string> isimler = new MyList<string>();
            isimler.Add("elyase");

            Console.WriteLine("Hello World!");
        }
    }
}
