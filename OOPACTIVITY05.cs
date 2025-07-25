using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPACTIVITY05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user for their name, age, and height

       Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
        if (!int.TryParse(Console.ReadLine(), out int age) || age <= 0)
                {
                    Console.WriteLine("Invalid age.");
                    return;
                }

            Console.Write("Enter height: ");
            if (!float.TryParse(Console.ReadLine(), out float height) || height <= 0)
            {
                Console.WriteLine("Invalid height.");
                return;
            }

            Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}");
          





        }
    }
}
