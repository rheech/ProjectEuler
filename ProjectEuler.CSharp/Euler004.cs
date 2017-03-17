using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ProjectEuler.CSharp
{
    class Euler004
    {
        // Project Euler Problem #4: Largest palindrome product
        // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        // Find the largest palindrome made from the product of two 3-digit numbers.

        static void Main(string[] args)
        {
            int[] answer = GetLargestPalindedromeOfThreeDigits();

            Console.WriteLine("The largest palinedrome of three digits is: {0} * {1} = {2}", answer[0], answer[1], answer[0] * answer[1]);
            Console.ReadLine();
        }

        static int[] GetLargestPalindedromeOfThreeDigits()
        {
            int x = 0, y = 0;

            for (int i = 100; i < 1000; i++)
            {
                int temp;

                for (int j = 100; j < 1000; j++)
                {
                    temp = i * j;

                    if (IsPalinedrome(temp) && temp > x * y)
                    {
                        x = i;
                        y = j;
                    }
                }
            }

            return new int[] { x, y };
        }

        static bool IsPalinedrome(int number)
        {
            int point = Convert.ToInt32(Math.Floor(Math.Log10(number)));
            int pointHalf = Convert.ToInt32(Math.Ceiling(point / 2.0));
            string numText = Convert.ToString(number);
            string numTextRev = Strings.StrReverse(numText);

            return numText.Substring(0, pointHalf) == numTextRev.Substring(0, pointHalf);
        }
    }
}
