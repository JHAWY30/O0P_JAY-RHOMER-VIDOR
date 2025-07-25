using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.Write("Enter number: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine();


            switch (op)
            {
                case "+":
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;

                case "-":
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;

                case "*":
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;

                case "/":
                    if (num2 == 0)
                        Console.WriteLine("NOT ALLOWED");
                    else

                        Console.WriteLine("Result: " + (num1 / num2));
                    break;

                default:
                    Console.WriteLine("Invalid operator.");
                    break;

            }
        }
    }
}
