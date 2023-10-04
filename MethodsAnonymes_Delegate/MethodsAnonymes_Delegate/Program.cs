using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// public delegate void Show(string message); // Also put Here 

public delegate void Operation(int n);


namespace MethodsAnonymes_Delegate
{
    internal class Program
    {

        public delegate void Show(string message);
        static void Main(string[] args)
        {

            Show show = delegate (string message)
            {
                Console.WriteLine($"Welcome to {message}");
            };

            show("Method Anonym using Delegate");


            int i = 4;

            Operation add = delegate (int n) { 
                Console.WriteLine("the value is  = {0}", i + n);
            };
            add(10);


            Console.ReadLine();

        }
    }
}
