using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Type in a word or phrase to find it's vowel score:");
            string input = Console.ReadLine().ToLower();

            // MARK: Result
            Console.WriteLine($"Score: {VowelCount(input)}");
            Console.ReadKey();
        }

        public static Dictionary<char, int> vowelScores = new Dictionary<char, int>()
        {
            { 'a', 1 },
            { 'e', 2 },
            { 'i', 3 },
            { 'o', 4 },
            { 'u', 5 },
            { 'y', 9 }
        };

        public static int VowelCount(string text)
        {
            int totalScore = 0;
            for(int i=0; i<text.Length; i++)
            {
                int points = 0;
                if (vowelScores.TryGetValue(text[i], out points))
                {
                    totalScore += points;
                }
            }
            return totalScore;
        }
    }
}
