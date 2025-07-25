using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            int count;

            Console.Write("Input a sentence: ");
            sentence = Console.ReadLine();

            count = 0;

            foreach (char c in sentence)
            {
                if (char.IsUpper(c))
                    count++;
            }

            Console.WriteLine("Total Uppercase letters are: " + count);

        }
    }
}
