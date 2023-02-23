using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace negyszog
{
    class negyszog
    {
        private int a;
        private int b;
        private int T;
        private int K;

        public negyszog() { }

        public negyszog(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void setA(int a) {
            if (a > 1000)
            {
                Console.Write("Az oldal nem lehet nagyobb mint 1000");
            }else
            this.a = a;
        }
        public void setB(int b) {
            if (b > 1000)
            {
                Console.Write("Az oldal nem lehet nagyobb mint 1000");
            }else 
            this.b = b;
        }

        public int getA(int a) { return this.a = a; }
        public int getB(int b) { return this.b = b; }

        public int setTerulet()
        {
            this.T = this.a * this.b;
        }

        public int getTerulet()
        {
            return this.T;
        }
        public int setkerulet()
        {
            this.K = this.a + this.b * 2;
        }

        public int getKerulet()
        {
            return this.K;
        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            negyszog n1 = new negyszog();
            kiirOldal(n1.getA(), n1.getB());

            n1.setA(1);
            n1.setB(2);

            kiirOldal(n1.getA(), n1.getB());
            n1.setTerulet();
            n1.setkerulet();
            kiirKerTer(n1.getTerulet(), n1.getKerulet());

            negyszog n2 = new negyszog();
            kiirOldal(n2.getA(), n2.getB());
            n2.setTerulet();
            n2.setkerulet();
            kiirKerTer(n2.getTerulet(), n2.getKerulet());

            Console.ReadKey();
        }

        static private void kiirOldal(int a, int b)
        {
            Console.WriteLine($"Az n1 negyszog oldalai: a={a} b={b}");
        }

        static private void kiirKerTer(int a, int b)
        {
            Console.WriteLine($"Az n1 negyszog terulet={a}, kerulet={b}");
        }
    }
}
