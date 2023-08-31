using System;

namespace VotePresidente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = CalculatVoteForPresidente(20);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static int CalculatVoteForPresidente(int age)
        {

            int presidents = 0;

            int eligibleAgeToVote = age - 18;
            if(eligibleAgeToVote <= 0)
            {
                Console.WriteLine("Not eligeble to vote, you must great than 18 years");
                return 0;
            }

            for(int i=1; i <= eligibleAgeToVote; i++)
            {
                if(i % 4 == 0)
                {
                    presidents++;
                }
            }

            return presidents;
            
        }
    }
}
