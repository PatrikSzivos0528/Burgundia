using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazi_feladat12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a dinnye átmérőjét:  ");
            int atm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg mennyi dinnye van: ");
            int db = Convert.ToInt32(Console.ReadLine());

            float n = ((atm * 2 + 60)/100);
            float s = (float)Convert.ToDouble(n);
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
