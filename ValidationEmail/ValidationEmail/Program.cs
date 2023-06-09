using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationEmail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValidationEmail("ettarak.zouhair"); // false
            ValidationEmail("ettarak.zouhair@gmail.com"); // true
            ValidationEmail("155-45@gmail.com"); // false

            Console.ReadKey();
        }

        public static void ValidationEmail(string email)
        {
             // 1 step 
            char firstChar = email[0];
            string atSymbol = "@";
            string dotCom = ".com";

            // check if email start with symbol or Numbers
            if(char.IsNumber(firstChar) || char.IsSymbol(firstChar))
            {
                Console.WriteLine("\nSorry, emails can't start with Numbers ou Symbols !!");
                return;
            }

            // check if email have @
            if(!email.Contains(atSymbol))
            {
                Console.WriteLine("\nSorry, Yu have to include an '@' charater ...");
                return;
            }
            // check if email have .com in the end
            if(email.Substring(email.Length -4) != dotCom)
            {
                Console.WriteLine("\nSorry, Gotta have a '.com' at the end ...");
                return;
            }
            // validation true 
            Console.WriteLine("\nEmail {0} is valid ", email);
        }
    }
}
