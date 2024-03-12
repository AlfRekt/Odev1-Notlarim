using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number whose factors you want to see: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] divisors;
            int a = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    a++;
                }
            }

            divisors = new int[a];

            int b = 0;
            for(int x = 1; x < number; x++)
            {
                if (number % x == 0)
                {
                    divisors[b] = x;
                    b++;
                }
            }

            Console.Write("Number {0}'s divisors are: ", number);

            for (int i = 0; i < divisors.Length; i++)
            {
                if(i == (divisors.Length - 1))
                {
                    Console.Write(divisors[i]);
                }
                else
                {
                    Console.Write(divisors[i] + ", ");
                }
            }

            Console.ReadLine();
        }
    }
}
