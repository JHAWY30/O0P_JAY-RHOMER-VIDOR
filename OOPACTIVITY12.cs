using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
            return;
        }

        if (number % 2 == 0)
            Console.WriteLine("Even number");
        else
            Console.WriteLine("Odd number");
Write to Jay Rhomer Vidor

        }
    }
}
