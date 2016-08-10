using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /// <summary>
    /// a demonstration of the speed of an array, list, and hashset using nested for loops
    /// </summary>
    class EffeciencyDemo
    {
        public static void RunWithList()
        {
            // make a list of 100,000 ints

            var list = new List<int>();

            for (int i = 0; i < 100000; i++)
            {
                list.Add(i);
            }

            // loop over the list n^2 times

            // outer loop interates until i is 
            for (int i = 0; i < list.Count; i++)
            {
                // j starts at i, which means, for example, when i is 9000, we're only checking nums between 9000 and 10000
                for (int j = i; j < list.Count; j++)
                {
                    if (j == 0)
                        Console.WriteLine("Start!");
                }
                // primitive progress bar
                if (i % 1000 == 0)
                    Console.WriteLine(i);
            }

        }

        public static void RunWithArray()
        {
            // make a list of 100,000 ints

            var array = new int[100000];

            for (int i = 0; i < 100000; i++)
            {
                array[i] = i;
            }

            // loop over the list n^2 times

            // outer loop interates until i is 
            for (int i = 0; i < array.Length; i++)
            {
                // j starts at i, which means, for example, when i is 9000, we're only checking nums between 9000 and 10000
                for (int j = i; j < array.Length; j++)
                {
                    if (j == 0)
                        Console.WriteLine("Start!");
                }
                // primitive progress bar
                if (i % 1000 == 0)
                    Console.WriteLine(i);
            }
        }

        public static void RunWithHashSet()
        {
            // make a list of 100,000 ints

            var hash = new HashSet<int>();

            for (int i = 0; i < 100000; i++)
            {
                hash.Add(i);
            }

            // loop over the list n^2 times

            // outer loop interates until i is 
            for (int i = 0; i < hash.Count; i++)
            {
                // j starts at i, which means, for example, when i is 9000, we're only checking nums between 9000 and 10000
                for (int j = i; j < hash.Count; j++)
                {
                    if (j == 0)
                        Console.WriteLine("Start!");
                }
                // primitive progress bar
                if (i % 1000 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
