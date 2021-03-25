using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Engin", "Ali" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);

            /* 
                 names[2] = "Ahmet";

                 Yukarıdaki kod satırı, array sınırları aşıldığı için hata verecektir.
            */

            List<string> fruits = new List<string> { "Elma", "Armut" };
            Console.WriteLine(fruits[0]);
            Console.WriteLine(fruits[1]);

            fruits.Add("Çilek");
            Console.WriteLine(fruits[2]);

            /* 
                 fruits.Add("Çilek");

                 Yukarıdaki kod satırı, list için sabit boyut sınırı olmadığından çalışacaktır.
            */

        }
    }
}
