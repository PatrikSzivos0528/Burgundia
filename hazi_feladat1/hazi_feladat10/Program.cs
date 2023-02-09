using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazi_feladat10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg az első számot: ");
            int firstnum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a második számot: ");
            int secondnum = Int32.Parse(Console.ReadLine());


            Random random = new Random();
            int randomNumber = random.Next(firstnum, secondnum);

            Int32 loop = 0;
            do
            {
                loop++;
            }
            while (loop > 4);


        }
    }
}
