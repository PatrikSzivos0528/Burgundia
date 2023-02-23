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
            return this.a * this.b;
        }

        public int getTerulet()
        {
            return this.T;
        }
        public int setkerulet()
        {
            return this.a + this.b * 2;
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

            Console.Write($"Az n1 négyszög oldalai: a={0}, b={1}", n1.getA(), n1.getB());

            Console.ReadKey();
        }
    }
}
