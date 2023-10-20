using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciTriangle
{
    public class Program
    {
        static void Main(string[] args)
        {

            int a=0, b=1, i,c,n,j;

            Console.WriteLine("Enter The Limit of traingle of fibonacci: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("the Result is :\n");

            for(i=1; i<= n; i++)
            {
                a = 0;
                b = 1;
                Console.Write(b + "\t");

                for(j=1; j<i; j++)
                {
                    c = a + b;
                    Console.Write(c + "\t");
                    a = b;
                    b = c;

                }

                Console.Write('\n');
            }

            Console.ReadKey();
        }
    }
}
