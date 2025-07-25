using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY10
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //Program to validate user input for name,age and email
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Name required.");
            return;
        }

        Console.Write("Enter age: ");
        if (!int.TryParse(Console.ReadLine(), out int age) || age < 1 || age > 120)
        {
            Console.WriteLine("Invalid age.");
            return;
        }

        Console.Write("Enter email: ");
        string email = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
        {
            Console.WriteLine("Invalid email.");
            return;
        }

        Console.WriteLine("All fields are valid.");
        }
    }
}
