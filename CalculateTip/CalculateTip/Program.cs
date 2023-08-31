using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the cost of your meal to calculate tip options: ");
            var input = int.Parse(Console.ReadLine());

            // Result 
            var tips = CalculateTip(input);
            Console.WriteLine($"\n10% = {tips.lower}, \n17.5% = {tips.midium}, \n25% = {tips.higher}");
            Console.ReadKey();
        }

         public static (string lower, string midium, string higher) CalculateTip(int cost)
        {
            string lowerTiper = Math.Round(cost * 0.10, 2).ToString("#0.00");
            string midTiper = Math.Round(cost * 0.175, 2).ToString("#0.00");
            string higerTiper = Math.Round(cost * 0.25, 2).ToString("#0.00");

            return (lowerTiper, midTiper, higerTiper);
        }
    }
}
