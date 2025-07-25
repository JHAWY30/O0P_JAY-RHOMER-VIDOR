using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            int lenght;

            Console.Write("type a single word: ");
            word = Console.ReadLine();
            bool isPalindrome = true;

            int length = word.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (word[i] != word[length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not a palindrome");
        }
    }
}
