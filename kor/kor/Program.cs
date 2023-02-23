using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kor
{
    class Kor
    {
        private int r;
        private double Kerulet;
        private double Terulet;

        public Kor() { }


        public Kor(int r)
        {
            this.r = r;
        }

        public void setR(int r)
        {
            this.r = r;
        }
        public int getR(int r) { return this.r = r; }

        public double setKerulet() => this.Kerulet = 2 * this.r * Math.PI;
        public double getKerulet()
        {
            return this.Kerulet;
        }
        public double setTerulet() => this.Terulet = Math.Pow(r, 2) * Math.PI;
        public double getTerulet()
        {
            return this.Terulet;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kor kor = new Kor();
            kor.setR(3);

            
            kor.setTerulet();
            KiirTerulet((double)kor.getTerulet());
            kor.setKerulet();
            KiirKerulet((double)kor.setKerulet());

            Console.ReadKey();
        }
        static private void KiirTerulet(double r)
        {
            Console.WriteLine($"A kör terulete={r}");
        }
        static private void KiirKerulet(double r)
        {
            Console.WriteLine($"A kör kerulete={r}");   
        }

    }
}
