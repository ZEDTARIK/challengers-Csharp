using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {


         

                Console.Write("Enter the number of Fibonacci numbers to generate: ");
                int n = int.Parse(Console.ReadLine());

                long[] fibonacciNumbers = new long[n];
                fibonacciNumbers[0] = 0;
                fibonacciNumbers[1] = 1;

            
                for (int i = 2; i < n; i++)
                {
                    fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
                }

                Console.WriteLine("Fibonacci Sequence:");
                foreach (long number in fibonacciNumbers)
                {
                    Console.Write($"{number} ");
                }

               
            

        Console.ReadKey();
        }

      
    }
}
