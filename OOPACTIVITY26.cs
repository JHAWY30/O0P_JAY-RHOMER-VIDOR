using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxLength = 0;
            int currentLength = 0;
           
            
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                    currentLength = 0;
                }
            }
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
            }

            Console.WriteLine($"Length of the longest word is: {maxLength}");
        }
    }
    }

