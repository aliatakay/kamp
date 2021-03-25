using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> fruits = new MyList<string>();

            fruits.Add("Elma");
            fruits.Add("Armut");
            fruits.Add("Çilek");

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits.Items[i]);
            }
        }
    }
}
