using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Grade: ");
            int grade = int.Parse(Console.ReadLine());

            if ((grade == 0))
                Console.WriteLine("Fail to compute grade.");
            {
                if (grade >= 100)
                    Console.WriteLine("Reject");
                else if (grade >= 90)
                    Console.WriteLine("Grade: A");
                else if (grade >= 80)
                    Console.WriteLine("Grade: B");
                else if (grade >= 70)
                    Console.WriteLine("Grade: C");
                else if (grade >= 60)
                    Console.WriteLine("Grade: D");
                else if (grade <= 60)
                    Console.WriteLine("Grade: F");
            }
        }
    }
}
