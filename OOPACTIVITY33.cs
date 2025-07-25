using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            string result;

            Console.Write("Input a sentence: ");
            string sentence = Console.ReadLine();

            Console.Write("Convert to (upper/lower): ");
             choice = Console.ReadLine().Trim().ToLower();

            if (choice != "upper" && choice != "lower")
            {
                Console.WriteLine("Invalid choice!.");
                return;
            }

             result = "";

            foreach (char ch in sentence)
            {
                if (choice == "upper")
                {
                    if (ch >= 'a' && ch <= 'z')
                    {
                        result += (char)(ch - ('a' - 'A'));
                    }
                    else
                    {
                        result += ch;
                    }
                }
                else 
                {
                    if (ch >= 'A' && ch <= 'Z')
                    {
                        result += (char)(ch + ('a' - 'A'));
                    }
                    else
                    {
                        result += ch;
                    }
                }
            }

            Console.WriteLine("converted sentence");
            Console.WriteLine(result);
        }
    }
}
