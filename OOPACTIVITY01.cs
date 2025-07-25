using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your First name: ");
            String FirstName = Console.ReadLine();

            Console.Write("Enter your Last name: ");
            String LastName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName))
            {
                Console.WriteLine("Error: First Name and Last Name cannot be empty.");
            }
            else
            {
                Console.WriteLine($"Your Full Name is : {FirstName} {LastName}");
            }

        }
    }
}
