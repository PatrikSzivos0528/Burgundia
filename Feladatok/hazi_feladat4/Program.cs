using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viz_goz_jeg
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Írd be a víz hőmérsékletét: ");
            double homerseklet = Convert.ToDouble(Console.ReadLine());
            if (homerseklet <= 0)
            {
                Console.WriteLine("A víz halmazállapota: jég.");
            }
            else if (homerseklet > 0 && homerseklet < 100)
            {
                Console.WriteLine("A víz halmazállapota: folyékony.");
            }
            else if (homerseklet >= 100)
            {
                Console.WriteLine("A víz halmazállapota: gáz.");
            }
            Console.ReadKey();
        }
    }
}