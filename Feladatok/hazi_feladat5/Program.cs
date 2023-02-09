using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pontoktavolasga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Írd be az 1. pont x koordinátáját: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Írd be az 1. pont y koordinátáját: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Írd be az 2. pont x koordinátáját: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Írd be az 2. pont y koordinátáját: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A két pont közötti távolság: {Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))}");
        }
    }
}