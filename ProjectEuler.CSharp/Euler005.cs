using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.CSharp
{
    class Euler005
    {
        // Project Euler Problem #4: Smallest multiple
        // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

        static void Main(string[] args)
        {
            int answer = GetNumberEvenlyDivisible(1, 20);

            Console.WriteLine("The the smallest positive number that is evenly divisible by all of the numbers from 1 to 20 is: {0}", answer);
            Console.ReadLine();
        }
        
        static int GetNumberEvenlyDivisible(int from, int to)
        {
            bool isEvenlyDivisible = true;
            int num = 0;

            do
            {
                num++;
                isEvenlyDivisible = true;

                for (int i = from; i <= to; i++)
                {
                    isEvenlyDivisible &= ((num % i) == 0);

                    if (!isEvenlyDivisible)
                    {
                        break;
                    }
                }

            } while (!isEvenlyDivisible);

            return num;
        }
    }
}
