using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponthatarok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Írd be a pontszámot: ");
            int pont = Convert.ToInt32(Console.ReadLine());
            if (pont <= 100 && pont >= 90)
                Console.WriteLine("Jeles");
            else if (pont < 90 && pont >= 80)
                Console.WriteLine("Jó");
            else if (pont < 80 && pont >= 65)
                Console.WriteLine("Közepes");
            else if (pont < 65 && pont >= 50)
                Console.WriteLine("Elégséges");
            else if (pont < 50 && pont >= 0)
                Console.WriteLine("Elégtelen");
            else
                Console.WriteLine("Hibás adat!");
            Console.ReadKey();
        }
    }
}