using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Simple program that adds 10 to 0 number input
            Console.Write("Enter a number (digits only): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Invalid input. Must be digits only.");
                return;
            }

            int result = number + 10;
            Console.WriteLine($"Result after adding 10: {result}");
        }
    }

}
    

