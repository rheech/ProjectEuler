using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.CSharp
{
    class Euler003
    {
        // Project Euler Problem #3: Largest prime factor
        // The prime factors of 13195 are 5, 7, 13 and 29.
        // What is the largest prime factor of the number 600851475143?

        static void Main(string[] args)
        {
            decimal answer = GetLargestPrimeFactorOf(600851475143);
            Console.WriteLine("The largest prime factor of the number 600851475143 is: {0}", answer);
            Console.ReadLine();
        }

        static decimal GetLargestPrimeFactorOf(decimal bound)
        {
            decimal i;

            for (i = 2; i < bound; i++)
            {
                if (bound % i == 0)
                {
                    bound /= i;
                }
            }

            return i;
        }
    }
}
