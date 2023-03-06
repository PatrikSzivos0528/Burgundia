using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szigetoop
{
    internal class Program
    {
        static void Main()
        {
            string s;
            #region 1.példa
            if (true) 
            { 
                s = "001111111100111100111111101010100011111111100111";
                Szigetszamolas sz1 = new Szigetszamolas();
                sz1.setData(s);
                sz1.Szamol();
                Console.WriteLine($"A szigetek száma: {sz1.getIslandCount()}, a leghosszabb hossz: {sz1.getMaxIslandLenght()}");
            }
            #endregion

            string s2;
            #region 2.példa
            if (true) 
            {
                s2 = "001010101010101010101010000001111101010101011111111111111111010101010110101";
                Szigetszamolas sz2 = new Szigetszamolas();
                sz2.setData(s2);
                sz2.Szamol();
                Console.WriteLine($"A szigetek száma: {sz2.getIslandCount()}, a leghosszabb hossz: {sz2.getMaxIslandLenght()}");
            }
            #endregion
            Console.ReadKey();
        }
    }
}
