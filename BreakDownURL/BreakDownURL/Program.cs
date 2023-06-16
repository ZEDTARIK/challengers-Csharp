using System;
using System.Linq;

namespace BreakDownURL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = "www.google.com/BreakDownUrl/todo-apps";

            var components = BreakDowURL(url);
            for(int i=0; i< components.Length; i++)
            {
                var indent = new string(' ', i * 2);
                Console.WriteLine($"{indent} -> {components[i]}");
            }
            
            
            Console.ReadKey();
        }

        public static string[] BreakDowURL(string urlString)
        {
            // remove wwww
            string noWWW = urlString.Remove(0, 4);
            // NoDash
            string noDashs= noWWW.Replace("-", "");
            // split 
            string[] components = noDashs.Split('/');
            // alternative
            //string[] x = url.Remove(0, 4).Replace("-", " ").Split('/');
            return components;
        }
    }
}
