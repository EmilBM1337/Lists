using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ages = new List<int>();
            ages.Add(5);
            ages.Add(17);
            ages.Add(20);
            ages.Add(40);
            ages.Add(91);

            List<string> names = new List<string>() { "Bjarne", "Bo", "Bob", "Brian", "Ben"};
            List<double> percentages = new List<double>() { 0.75, 0.23, 0.69, 0.17};
            List<bool> areMarried = new List<bool>() { true, false, false, true, true};

            

            for (int i = 0; i < ages.Count; i++)
            {
                Console.WriteLine(ages[i]);
            }

            Console.WriteLine("");

            for (int u = 0; u < names.Count; u++)
            {
                Console.WriteLine(names[u]);
            }

            Console.WriteLine("");

            foreach (double percentage in percentages)
            {
                Console.WriteLine(percentage);
            }

            Console.WriteLine("");

            foreach (bool married in areMarried)
            {
                Console.WriteLine(married);
            }
        }
    }
}
