using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctNumbersArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 3, 4, 4, 5,6  };

            var uniqueValue = numbers.Distinct().ToList();
            //Console.WriteLine(distinctNumbers);

            foreach (var number in uniqueValue)
            {
                Console.Write($"{number} ");
            }
            Console.ReadLine();

            
        }
    }
}
