//#define VERBOSE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{


    /*
     * Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
     * 
     * How many such routes are there through a 20×20 grid?
    */

    class Problem015
    {
        

        static long[,] grid;

        /// <summary>
        /// solves problem 15, recursively
        /// </summary>
        /// <param name="max">the size of the grid to solve</param>
        /// <returns></returns>
        public static long Solve(int max)
        {
            // array to contain cached results
            grid = new long[max+1, max+1];


            return Recurse(0, 0, max);;
        }

        private static long Recurse(int x, int y, int max)
        {

            // check to see if we've found this value before
            if (grid[x, y] != 0)
            {
                return grid[x, y];
            }
#if VERBOSE
            Console.WriteLine("checking x = {0}, y = {1}", x, y);
            Console.WriteLine(grid.ToString());
#endif

            if (x == max || y == max) {
                // we're at the bottom right, so return because you found a path

#if VERBOSE
                Console.WriteLine("***************found a path!");
#endif
                return 1; 
            }

            // store the return in the cache grid      
            return grid[x,y] = (Recurse(++x, y, max) + Recurse(--x, ++y, max)); // x-- because it was incremented in the alst call

        }
    }
}
