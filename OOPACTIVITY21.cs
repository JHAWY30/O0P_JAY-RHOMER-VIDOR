﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Greet");
            Console.WriteLine("2. Show Date");
            Console.WriteLine("3. Exit");
            Console.Write("choose (1–3): ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Hello, User!");
                    break;
                case 2:
                    Console.WriteLine("Current date: " + DateTime.Now.ToShortDateString());
                    break;
                case 3:
                    Console.WriteLine("Exiting... ");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;

            }
        }
    }
}
