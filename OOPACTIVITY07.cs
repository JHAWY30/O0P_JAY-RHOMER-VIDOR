using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENTER A NUMBER: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.Write("ENTER ANOTHER NUMBER: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.Write("SELECT AN OPERATOR (+, -, *, /: )");
            string opera = Console.ReadLine();

            float result;

            if (opera == "+")
            {
                result = num1 + num2;
                Console.WriteLine("The result is: " + result);
            }
            else if (opera == "-")
            {
                result = num1 - num2;
                Console.WriteLine("The result is: " + result);
            }
            else if (opera == "*")
            {
                result = num1 * num2;
                Console.WriteLine("The result is: " + result);
            }
            else if (opera == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine("The result is: " + result);
                }
            }
        }
    }
}
