using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a nunber positive : ");
            string result= Console.ReadLine();

            // Convert the input string to an integer
            int number;
            if(int.TryParse(result, out number))
            {
                Console.WriteLine($"Factoriel of {result}  is : {Factoriel(number)}");
            }

            Console.ReadKey();
        }

        public static int Factoriel(int x)
        {
            int fact = 1;
            if(x == 1)
            {
                return 1;
            }
            for(int i = 2; i <= x; i++)
            {
                fact *= i;
            }

            return fact;
        }
    }
}
