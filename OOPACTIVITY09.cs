﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter an integer: ");

            try
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
            }
            catch
            {
                Console.WriteLine("NON_INTEGER INPUT ");
            }
          
        }
    }
}
