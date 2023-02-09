using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamok_bekerdezese
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string oszthatoe = "";
            Console.Write("Írj be egy számmot: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 3 == 0)
                oszthatoe += "3-al";
            if (a % 4 == 0)
                oszthatoe += "4-el";
            if (a % 9 == 0)
                oszthatoe += "9-el";
            Console.WriteLine($"A szám osztható{oszthatoe}!");
            Console.ReadKey();
        }
    }
}
