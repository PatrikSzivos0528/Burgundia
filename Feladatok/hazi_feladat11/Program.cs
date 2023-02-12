using System;

namespace veletlen_szamok_listaja
{
    class Program
    {
        public static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(random.Next(a, b));
            }
            Console.ReadKey();
        }
    }
}