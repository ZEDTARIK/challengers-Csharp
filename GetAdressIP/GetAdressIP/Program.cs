using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GetAdressIP
{
    internal class Program
    {
        [Obsolete]
        static void Main(string[] args)
        { 
            // Récupérer le nom de l'hôte
            string host = Dns.GetHostName();
            Console.WriteLine("Le nom de l'hôte est :" + host);

            // Récupérer l'adresse IP
            string ip = Dns.GetHostByName(host).AddressList[0].ToString();
            Console.WriteLine("Mon adresse IP est :" + ip);

            Console.ReadLine();
        }
    }
}
