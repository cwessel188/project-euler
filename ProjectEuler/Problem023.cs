using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{

    /*
     *A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.

A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.

As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24. By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers. However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed as the sum of two abundant numbers is less than this limit.

Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers. 
     */
    class Problem023 : Problem
    {
        /* STRATEGY
         * calculate all abundant #s below 28123
         * put them in a hashset
         * make a bitset
         * for each i, loop over half of abundant # list, looking for the difference to also be in the list.
         * 
         * OPTOMIZATIONS
         * first double each abundant# and flip them in the bitset
         * add each ab# to the smallest ad# and flip it's bit
         * 
         */
         

        public int Solve()
        {

            int sum = 0;

            // build set of abundant numbers.
            // if you want to take forever to run this, change 'HashSet' to 'List'
            var abundantNumbers = new HashSet<int>();

            for (int i = 1; i < 28124; i++)
            {
                if (IsAbundant(i))
                {
                    abundantNumbers.Add(i);
                }
            }
            // boom now the set is full

            // bitset, initialized to false
            bool[] bitset = new bool[28124];


            // this is kinda brute-forcey
            for (int i = 0; i < bitset.Length; i++)
            {
                if (bitset[i] == false)
                {
                    foreach (var num in abundantNumbers)
                    {
                        if (abundantNumbers.Contains(i - num)) // disqualified
                        {
                            bitset[i] = true;
                            break;
                        }
                    }
                }
            }

            // add up all that's left
            for (int i = 0; i < bitset.Length; i++)
            {
                if (!bitset[i])
                {
                    if (i > 15000) { 
                        ;
                    }
                    sum += i;
                }
            }

            return sum;
        }

        private bool IsAbundant(int i)
        {
            return SumOfProperDivisors(i) > i;
        }

        private int SumOfProperDivisors(int num) {

            
            List<int> divisors = new List<int>();
            int sum = 1; // 1 is a proper divisor but if we add it below it will also add 'sum'

            // get divisors, starting at 2
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    divisors.Add(i);

                    // handle special case for square numbers
                    if (i * i != num)
                    {
                        divisors.Add(num / i);
                    }
                }
            }


            foreach (var divisor in divisors)
            {
                sum += divisor;
            }
            return sum;
        }
    }
}
