using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mezogazdasgi_joslas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNum = random.Next(5, 15);
            Console.Write("Elvetett búza mennyisége (Tonna): ");
            double elvetett_buza = Convert.ToDouble(Console.ReadLine());
            double hozam = elvetett_buza * randomNum;
            if (randomNum >= 5 && randomNum <= 8)
                Console.WriteLine($"A következő év átlag alatti lesz. Várható hozam: {hozam} Tonna.");
            if (randomNum >= 9 && randomNum <= 12)
                Console.WriteLine($"A következő év átlagos lesz. Várható hozam: {hozam} Tonna.");
            if (randomNum >= 13 && randomNum <= 15)
                Console.WriteLine($"A következő év átlag felettti lesz. Várható hozam: {hozam} Tonna.");
            Console.ReadKey();
        }
    }
}
