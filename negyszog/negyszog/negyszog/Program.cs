using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace negyszog
{
    class Negyszog
    {
        private int a;
        private int b;
        private int T;
        private int K;

        public Negyszog() { }

        public Negyszog(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void setA(int a)
        {
            if (a > 1000)
            {
                Console.Write("Az oldal nem lehet nagyobb mint 1000");
            }
            else
                this.a = a;
        }
        public void setB(int b)
        {
            if (b > 1000)
            {
                Console.Write("Az oldal nem lehet nagyobb mint 1000");
            }
            else
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

    class Hasab : Negyszog
    {
        private int m;
        private int b;
        private double terfogat;
        private double kerulet;


        public Hasab() : base () { }

        public Hasab( int a ,int m, int b) : base (a, b)
        {
            this.m = m;
        }

        public void setM(int m) { this.m = m;}

        public void setNegyszog()
        {
            base.setkerulet();
            base.setTerulet();
        }

        public void setTerfogat()
        {
            this.terfogat = base.getTerulet() * this.m;
        }

        public void setFelszín()
        {
            this.fekszín = base.getTerulet() * this.m + 2 * this.getTerulet ();
        }

        public double getTerfogat() { return this.terfogat; }
        public double getFelszín() { return this.felszín; }

    }

    internal class Program
    {
        enum nyomtat { oldal, kerter, osszes }

        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Hasab példa");
            Hasab h1 = new Hasab(3, 6, 9);
            h1.setNegyszog();
            h1.setTerfogat();
            h1.setFelszín();

            Console.WriteLine($"Felszín: {h1.getFelszín()}, Térfogat: {h1.getTerfogat()}");

            Console.ReadKey();
        }
    }
}
