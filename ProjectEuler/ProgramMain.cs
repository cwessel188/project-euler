using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class ProgramMain
    {
        static void Main(string[] args)
        {
          
           // Problem011.Solve();

            DateTime start = DateTime.Now;

            Console.WriteLine("Start Time: {0}", start);


            /** PROBLEM 15

            for (int i = 0; i < 21; i++)
            {
                int size = i;
            long result = Problem015.Solve(size);

            Console.WriteLine("For a grid of size {0} there are {1} paths.", size, result);
            }
            */

            Problem p = new Problem023();

            var result = p.Solve();


            Console.WriteLine("Elapsed Time: {0}", DateTime.Now - start);

            Console.Read();
        }

    }
}
