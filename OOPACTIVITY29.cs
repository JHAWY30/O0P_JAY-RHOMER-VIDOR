using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start; 
            int end;

            while (true)
            {
                Console.Write("Start integer: ");
                bool validStart = int.TryParse(Console.ReadLine(), out start);

                Console.Write("End integer: ");
                bool validEnd = int.TryParse(Console.ReadLine(), out end);

                if (!validStart || !validEnd)
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }
                if (start >= end)
                {
                    Console.WriteLine("Try again.");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"Prime numbers between {start} and {end} are");

            for (int num = start; num <= end; num++)
            {
                if (IsPrime(num))
                {
                    Console.Write(num + " ");
                }
            }

            Console.WriteLine();
        }
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;

        }
    }
}
