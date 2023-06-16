using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherLowerAverageValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add some Numbers : ");

            List<int> ints= new List<int>();

            for(int i=0; i<4; i++)
            {   
                int inputNumber = int.Parse(Console.ReadLine());
                ints.Add(inputNumber);
            }
            Console.WriteLine("-----------------------------------");
            HigherLowerAverageValue(ints);
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();
        }

        public static void HigherLowerAverageValue(List<int> numbers)
        {
            // sort
                numbers.Sort();

            // lower numbers
            int lowest = numbers[0];
            Console.WriteLine($"\nLowest numbers\t ->{lowest}");

            // higher Number
            int higest = numbers[numbers.Count - 1];
            Console.WriteLine($"\nhigest numbers\t ->{higest}");

            // total numbers
            int sum = 0;
            foreach ( int i in numbers)
            {
                sum += i;
            }
            Console.WriteLine($"\nTotal of numbers\t ->{sum}");


            // average Numbers
            Console.WriteLine($"\nAverage of Numbers\t ->{sum / numbers.Count}");
        }

    }
}
