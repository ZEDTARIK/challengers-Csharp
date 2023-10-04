using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ControlStructures
{
    class Operation <T>
    {
        public bool isEqual(T x, T y)
        {
            if(x.Equals(y)) return true;
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            // Récupérer la date et l'heure actuelle 
            DateTime dt = DateTime.Now;

            Console.WriteLine(dt.ToString("MM/dd/yyyy HH:MM"));
            Console.WriteLine();
            Console.WriteLine(" -----------------------------  ");


           try
            {
                string[] language = { "Java", "C#", "PHP", "Python", "Cobol" };


                for (int p = 0; p < language.Length; p++)
                {
                    Console.Write($" {language[p]}");
                }

                Console.WriteLine(" -----------------------------  ");
                Console.WriteLine();
                Console.WriteLine("Search inside table with word started with 'C'");
                Console.WriteLine();
                string result = Array.Find(language,
                                            item => item.StartsWith("c",
                                            StringComparison.OrdinalIgnoreCase)
                                           );
                Console.WriteLine("Find =>  {0}", result);

            } catch(ArgumentNullException e)
            {
                Console.Write("{0}", e.GetType(), e.ToString());
            }

            Console.WriteLine();
            Console.WriteLine(" -----------------------------  ");

            /*
            int i = 0, j = 0;

            label: i++; j += i;

            if (i < 10)
            {
                Console.Write(i + " "); //1 2 3 4 5 6 7 8 9
                goto label;
            }

            Console.WriteLine();
            Console.WriteLine(" -----------------------------  ");

            int i2 = 10;
            for (; ; )
            {
                Console.Write(i2 + " "); //10 8 6 4 2 0 -2 -4 -6
                if (i2 >= -5)
                    i2 -= 2;
                else
                    break;
            }

            Console.WriteLine();
            Console.WriteLine(" -----------------------------  ");
            Console.WriteLine("for with switch Case");
            Console.WriteLine();

            int val;
            for (val = -5; val <= 5; val++)
            {
                if (val > 0)

                    Console.Write($"{val}X ");
                else if (val < 0)
                    Console.Write($"{val}W ");

                switch (val)
                {
                    case 0:
                        Console.Write($"  ayToLearn ");
                        break;
                }
               
            }
            Console.WriteLine();
            Console.WriteLine(" -----------------------------  ");

            Console.WriteLine("Function ToBoolean");
            Console.WriteLine();

            int f = 2, r = i;
            if (Convert.ToBoolean((f | r & 5) & (r - 15 * 1)))
                Console.WriteLine(1); // 1
            else
                Console.WriteLine(0);

            Console.WriteLine();
            Console.WriteLine(" -----------------------------  ");

            Console.WriteLine("Continue and Break with condition");
            Console.WriteLine();

            int y;
            for(y = 0; y <= 10; y++)
            {
                if (y == 2)
                {
                    Console.Write(y + " "); continue;
                }
                else if (y != 2)
                {
                    Console.Write(y + " ");
                }
                else
                {
                    Console.Write(" break"); break;
                }
            }

            Console.WriteLine();
            Console.WriteLine(" -----------------------------  ");
            Console.WriteLine("Gestion Files");
            Console.WriteLine();

            string[] files = Directory.GetFiles(@"C:\Users\ettar\OneDrive\Pictures\Screenshots", 
                                                    "*.txt", 
                                                    SearchOption.AllDirectories);
                foreach (string file in files)
                    Console.WriteLine(file);


            Console.WriteLine();
            Console.WriteLine(" -----------------------------  ");

            Console.WriteLine("Comment extraire des nombres d’une chaîne de caractères en C#");
            Console.WriteLine();

            string str = "5 chiens, 3 chevaux, 40 chats et 2 oiseaux.";
                string[] numbers = Regex.Split(str, @"\D+");
                foreach (string nbr in numbers)
                {
                    int number;
                    if (int.TryParse(nbr, out number))
                    {
                        Console.Write(nbr);
                    }
                }

            Console.WriteLine();
            Console.WriteLine(" -----------------------------  ");

            Console.WriteLine("Remplacer plusieurs espaces par un seul en utilisant Regex en C# ");
            Console.WriteLine();

            string word = "Welcome       to WayToLearnX     !.";
            string newStr = Regex.Replace(word, "\\s+", " ");
            Console.WriteLine("Original String: " + word);
            Console.WriteLine("Cleaned String:  " + newStr);


            Console.WriteLine();
            Console.WriteLine(" -----------------------------  ");

            Console.WriteLine("Reflection :la réflexion est un processus permettant d’obtenir des métadonnées d’un type en cours d’exécution. ");
            Console.WriteLine();

            int a = 5;
            System.Type type = a.GetType();
            System.Console.WriteLine(type);
            Type t = typeof(System.String);
           
            Console.WriteLine("Les méthodes disponibles dans le type {0} sont :", t);
            MethodInfo[] infos = t.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            foreach (MethodInfo info in infos)
            {
                //Console.WriteLine(info);
            }

            Console.WriteLine();
            Console.WriteLine(" -----------------------------  ");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine(" Class Generic pour le but de la surcharge de method  ");

            Operation<int> obj1 = new Operation<int>();
            Console.WriteLine(obj1.isEqual(2, 2)); // true

            Operation<double> obj2 = new Operation<double>();
            Console.WriteLine(obj2.isEqual(0.75, 0.14)); // true

            */

            Console.WriteLine(" -----------------------------  ");
            Console.ReadLine();


        }
    }
}
