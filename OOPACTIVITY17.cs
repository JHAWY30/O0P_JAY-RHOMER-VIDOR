using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the program prompts the user for a number 1 between and 10
            Console.Write("Enter a number (1–10): ");
            if (!int.TryParse(Console.ReadLine(), out int num) || num < 1 || num > 10)
            {
                Console.WriteLine("Invalid input. Enter a number between 1 and 10.");
                return;
            }

            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }
}
