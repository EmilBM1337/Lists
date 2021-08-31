using System;
using System.Collections.Generic;

namespace Opgave_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Hans", "Gerda", "Knud", "Karsten", "Irene"};
            names.Insert(3, "Anders");
            names.Insert(4, "Johanne");

            List<int> ages = new List<int>() { 13, 14, 13, 15, 13, 14, 14, 15 };
            ages.Remove(13);
            ages.Remove(15);
            ages.RemoveAt(3);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("");

            foreach (int age in ages)
            {
                Console.WriteLine(age);
            }

            Console.ReadKey();
        }
    }
}
