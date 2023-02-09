using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazi_feladat17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("   2\na x + b x + c = 0 egyenlet gyökeinek meghatározása\n");
            Console.Write("a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c: ");
            c = Convert.ToDouble(Console.ReadLine());
            double d = Math.Pow(b, 2) - 4 * a * c, gyök1, gyök2;
            if (d < 0)
                Console.WriteLine("Nincs valós gyök.");
            else
            {
                if (d == 0)
                {
                    gyök1 = -b / (2 * a);
                    Console.WriteLine("Egy valós gyök van, értéke: {0}", gyök1);
                }
                else
                {
                    gyök1 = (-b + Math.Sqrt(d)) / (2 * a);
                    gyök2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("Két valós gyök van, értékük: {0} és {1}", gyök1, gyök2);
                }
            }
            Console.Write("A kilépéshez üss le egy billentyűt!");
            Console.ReadKey();
        }
    }
}
