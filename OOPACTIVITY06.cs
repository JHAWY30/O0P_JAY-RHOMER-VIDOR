using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPACTIVITY06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENTER A GRADE (0-100): ");
            int grade = int.Parse(Console.ReadLine());

 
            {
                if (grade >= 100)
                    Console.WriteLine("Unable to compute grade. Please enter a number between 1-100.");
                else if (grade >= 90)
                    Console.WriteLine("Your Grade is: A");
                else if (grade >= 80)
                    Console.WriteLine("Your Grade is: B");
                else if (grade >= 70)
                    Console.WriteLine("Your Grade is: C");
                else if (grade >= 60)
                    Console.WriteLine("Your Grade is: D");
                else if (grade <= 60)
                    Console.WriteLine("Your Grade is: F");

                if ((grade == 0))
                    Console.WriteLine("Unable to compute grade.");
            }
        }
    }
}
