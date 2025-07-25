using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int attempts = 0;

            while (attempts < 3)
            {
                Console.Write("ENTER YOUR PIN: ");
                string pin = Console.ReadLine();

                if (pin == "1234")
                {
                    Console.WriteLine("Access granted");
                    return;
                }

                attempts++;
            }

            Console.WriteLine("Access denied");

        }
    }
}
