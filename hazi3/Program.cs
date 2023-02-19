using System;

namespace hazi3
{
    class Program
    {
        public static void Main()
        {
            string a = "egyik";
            string b = "masik";

            int x = String.Compare(a, b);

            if (x == 0)
            {
                Console.Write("A ket string egyenlo");
            }
            else if (x < 0)
            {
                Console.Write("AZ 'a' a kisebb");
            }
            else
            {
                Console.Write("A 'b' kisebb");
            }

            Console.ReadKey();
        }
    }
}