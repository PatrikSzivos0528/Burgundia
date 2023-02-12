using System;


namespace igazolatlan_hianyzasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hianyzasok;

            Console.Write("Add meg a hiányzások számait: ");
            hianyzasok = Convert.ToInt32(Console.ReadLine());

            if (10 < hianyzasok)
            {
                Console.Write("Add meg a szuletesi datumod: ");
                Console.ReadLine();

                Console.WriteLine($"Hianyzasok: {hianyzasok}");
                Console.Write("A buntetes kategoriaja: ");
                switch (hianyzasok)
                {
                    case > 40:
                        Console.Write("felfuggesztes");
                        break;
                    case > 30:
                        Console.Write("igazgatoi megrovas");
                        break;
                    case > 20:
                        Console.Write("osztalyfonoki into");
                        break;
                    case > 10:
                        Console.Write("figyelmeztetes");
                        break;
                    default:
                        break;
                }
            }
            Console.ReadKey();



        }

    }
}