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
          
           // Problem011.Run();

           // EffeciencyDemo.RunWithHashSet();

            DateTime start = DateTime.Now;


            for (int i = 0; i < 21; i++)
            {
                int size = i;
            long result = Problem015.Solve(size);

            Console.WriteLine("For a grid of size {0} there are {1} paths.", size, result);
            }
            


            Console.WriteLine("Elapsed Time: {0}", DateTime.Now - start);

            Console.Read();
        }

    }
}
