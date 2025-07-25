using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter price of item: ");
            float price = float.Parse(Console.ReadLine());

            Console.Write("Enter the Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            if (price > 0 && quantity > 0)
            {
                float total = price * quantity;
                Console.WriteLine($"Total cost: Php: {total}");
            }
            else
            {
                Console.WriteLine("Invalid input: Both price and the quantity must be in positive.");
            }
        }
    }
}
