using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            T//The program prompts the user to enter a word and prints it in reverse
        Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            Console.Write("Reversed word: ");
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
            Console.WriteLine();
        }
    }
    }
}
