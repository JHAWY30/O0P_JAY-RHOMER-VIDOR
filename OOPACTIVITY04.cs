using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperation in celsius: ");
            float celsius = float.Parse(Console.ReadLine());


            if ((celsius <= 100 && celsius >= -100))
            {
                float farenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"Temperature in Farenheit: {farenheit}");

            }
            else
            {
                Console.WriteLine("Invalid input. Enter a number between -100 and 100.");
            }
        }
    }
}
