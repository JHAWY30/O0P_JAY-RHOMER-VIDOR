using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password;

            Console.Write("Create strong password: ");
            password = Console.ReadLine();

            bool hasNumber = false, hasUpper = false;

            foreach (char c in password)
            {
                if (char.IsDigit(c)) hasNumber = true;
                if (char.IsUpper(c)) hasUpper = true;
            }

            if (password.Length >= 8 && hasNumber && hasUpper)
            {
                Console.WriteLine("Valid password");
            }
            else
            {
                Console.WriteLine("Invalid password.");
                Console.WriteLine("Missing:");
                if (password.Length < 8) Console.WriteLine("- At least 8 characters");
                if (!hasNumber) Console.WriteLine("- A number");
                if (!hasUpper) Console.WriteLine("- An uppercase letter");
            }
        }
    }
}
