using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Atlaghomerseklet
{
    internal class Program
    {
        static void Main()
        {
            //Hőmérsékletek tömbje
            int[,] data = new int[12, 30];

            // Hőmérséklet tömb feltöltése adatokkal
            setMatrix(data);

            //Kiíratás tömb
            kiirMatrix(data);

            //Példányosítom az osztályt
            Hofokszamitas afok = new Hofokszamitas(data);

            //Elvégeztetem vele a számításokat
            afok.szamitas();

            //Kiíratom a legmelegebb hónapot
            prLegmelegebbHonap(afok);

            //Kiíratom a leghidegebb hónapot
            prLeghidegebbHonap(afok);

            //Kiíratom a legmegelebb napot
            prLegmelegebbNap(afok);

            //Kiíratom a legmegelebb napot
            prLeghidegebbNap(afok);

            //Kiíratom az összefüggő 5 minuszos napot
            prOtminusz(afok);

            Console.ReadKey();
        }

        private static void prOtminusz(Hofokszamitas p)
        {
            NapiAdat[] napiAdats = new NapiAdat[5];
            napiAdats = p.getotMinusz();
            if (napiAdats[0].hofok < 0)
            {
                Console.WriteLine("Az öt összefüggő mínuszos nap a következő: ");
                for (int i = 0; i < napiAdats.Length; i++)
                {
                    Console.WriteLine("{0} {1}: {2}", napiAdats[i].honap, napiAdats[i].nap, napiAdats[i].hofok);
                }
            }
            else
            {
                Console.WriteLine("Nem volt összefüggöen 5 minuszos nap!");
            }
        }

        private static void prLeghidegebbHonap(Hofokszamitas afok)
        {
            Console.WriteLine("Az év leghidegebb hónapja: {0}: {1} fok", afok.getHaviMin().honap, afok.getHaviMin().hofok);
        }

        private static void prLegmelegebbHonap(Hofokszamitas afok)
        {
            Console.WriteLine("Az év legmelegebb hónapja: {0}: {1} fok", afok.getHaviMax().honap, afok.getHaviMin().hofok);
        }

        private static void prLeghidegebbNap(Hofokszamitas afok)
        {
            Console.WriteLine("Az év legmelegebb napja: {0} {1}: {2} fok", afok.getNapiMax().honap, afok.getNapiMax().nap, afok.getNapiMax().hofok);
        }

        private static void prLegmelegebbNap(Hofokszamitas afok)
        {
            Console.WriteLine("Az év leghidegebb napja: {0} {1}: {2} fok", afok.getNapiMin().honap, afok.getNapiMin().nap, afok.getNapiMin().hofok);
        }

        private static void kiirMatrix(int[,] data)
        {
            Console.WriteLine("\nAz éves hőmérséklet adatok: ");
            for (int i = 0; i < data.GetLength(0); i++)
            {
                Console.Write("\n {0}. hónap: ", i+1);
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write("{0}, ", data[i,j]);
                }
            }
        }

        private static void setMatrix(int[,] data)
        {
            //Havi min max hőmérsékletek tömbje
            int[,] minmax =
            {
                {-20,5},
                {-12,5},
                {-7,14},
                {-2,17},
                {10,19},
                {18,32},
                {25,38},
                {25,30},
                {12,25},
                {5,17},
                {-7,18},
                {-10,5}
            };
            //Munkaváltozok
            int mn = 0;
            int mx = 0;

            Random rn = new Random();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                mn = minmax[i,0];
                mx = minmax[i,1];

                for (int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = rn.Next(mn, mx);
                }
            }
        }
    }
}
