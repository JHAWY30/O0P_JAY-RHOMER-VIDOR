using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPACTIVITY22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            int index;


            Console.Write("Enter a word: ");
            word = Console.ReadLine();

            Console.Write("Enter a position (starting from 0): ");
            index = int.Parse(Console.ReadLine());

            if (index < 0 || index >= word.Length)
            {
                Console.WriteLine("Error! out of range.");
            }
            else
            {
                Console.WriteLine("Character at that position " + index + "is " + word[index]);
            }
        }
    }
}
