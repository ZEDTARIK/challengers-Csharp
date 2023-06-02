using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingForPresidente
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            Console.WriteLine( calculatePresidents(10));
            Console.ReadLine();
        }

        public static int calculatePresidents(int age)
        {
            int presidents = 0;
            int eligibleYear = age - 18;

            if(eligibleYear <= 0)
            {
                Console.WriteLine("Looks like you're not old enough to vote yet.!");
                return 0;
            }

            for(int i = 1; i <= eligibleYear; i++)
            {
                if(i % 4 == 0 )
                {
                    presidents++;
                }
            }
            Console.WriteLine("Voting for President: {0}", presidents);
            return presidents;
        }
    }
}
