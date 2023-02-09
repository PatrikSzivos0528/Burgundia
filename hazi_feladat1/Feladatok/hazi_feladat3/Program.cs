using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testomegindex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Írd be a magasságot (cm): ");
            double magassag = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.Write("Írd be a testsúlyt (kg): ");
            double suly = Convert.ToDouble(Console.ReadLine());
            double BMI = Math.Round(suly / Math.Pow(magassag, 2), 1);
            if (BMI < 20)
            {
                Console.WriteLine($"A BMI értéke: {BMI}. Az illető sovány!");
            }
            else if (BMI >= 20 && BMI <= 25)
            {
                Console.WriteLine($"A BMI értéke: {BMI}. Az illető a normál tartoményba tartozik!");
            }
            else if (BMI > 25)
            {
                Console.WriteLine($"A BMI értéke: {BMI}. Az illető a túlsúlyos!");
            }
            Console.ReadKey();
        }
    }
}