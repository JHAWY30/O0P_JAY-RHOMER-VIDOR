using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username;
            string password;

            do
            {
                Console.Write("Username: ");
                username = Console.ReadLine();

                Console.Write("Password: ");
                password = Console.ReadLine();

                if (username == "admin" && password == "1234")
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Try again.");
                }

            } while (username != "admin" || password != "1234");
        }
    }
}
