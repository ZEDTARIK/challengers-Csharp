using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of Fibonacci elements you'd like to calculate: ");
            int input = int.Parse(Console.ReadLine());
           
            // MARK: Result
            var sequence = CalculateFibonacci(input);
            foreach (var fibonacci in sequence)
            {
                Console.WriteLine(fibonacci);
            }

            Console.ReadKey();
        }


        public static List<int> CalculateFibonacci(int fibonacci)
        {
            List<int> result = new List<int>();

            int firstNumber = 0;
            int secondnumber = 1;

            result.Add(firstNumber);
            result.Add(secondnumber);

            for (int i = 2; i< fibonacci; i++)
            {
                int nextNumber = firstNumber + secondnumber;
                result.Add(nextNumber);
                firstNumber = secondnumber;
                secondnumber = nextNumber;
            }

            return result;
        }
    }
}
