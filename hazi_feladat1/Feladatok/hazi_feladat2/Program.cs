using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvaltasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1: Celsius > Farenheit");
                Console.WriteLine("2: Farenheit > Celsius");
                Console.WriteLine("ESC: Kilépés");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.Write("Celsius: ");
                        double celsius = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"{(celsius * 9 / 5) + 32}°F");
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.Write("Farenheit: ");
                        double farenheit = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"{(farenheit - 32) * 5 / 9}°C");
                        break;
                    default:
                        Console.WriteLine("Nincs ilyen lehetőség!");
                        break;
                }
                Console.ReadKey();
            }
        }
    }