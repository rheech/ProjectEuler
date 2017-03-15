using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.CSharp
{
    class Euler001
    {
        // Project Euler Problem #1
        // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        // Find the sum of all the multiples of 3 or 5 below 1000.

        static void Main(string[] args)
        {
            int answer = GetMultiplesOfThreeOrFive(1000);
            Console.WriteLine("Sum of all multiples of three or five is: {0}", answer);
            Console.ReadLine();
        }

        private static int GetMultiplesOfThreeOrFive(int number)
        {
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
