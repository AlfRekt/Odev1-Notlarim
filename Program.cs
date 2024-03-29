﻿using System;
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
            for(; ;)
            {
                Console.Write("Enter the number whose factors you want to see: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Divisors(number);
                Console.Write("Would you like to exit? (Yes/No): ");
                string answer = Console.ReadLine();
                if( answer == "Yes" )
                {
                    break;
                }
                else if( answer == "No" )
                {
                    continue;
                }
            }

            Console.ReadLine();
        }

        public static void Divisors(int number)
        {
            int[] divisors;
            int numberOfDivisors = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    numberOfDivisors++;
                }
            }

            divisors = new int[numberOfDivisors];

            int indexOfDivisor = 0;
            for(int x = 1; x < number; x++)
            {
                if (number % x == 0)
                {
                    divisors[indexOfDivisor] = x;
                    indexOfDivisor++;
                }
            }

            Console.Write("Number {0}'s divisors are: ", number);

            for (int i = 0; i < divisors.Length; i++)
            {
                if (i == (divisors.Length - 1))
                {
                    Console.Write(divisors[i]);
                }
                else
                {
                    Console.Write(divisors[i] + ", ");
                }
            }

            Console.Write(", " + number + "\n");
        }
    }
}
