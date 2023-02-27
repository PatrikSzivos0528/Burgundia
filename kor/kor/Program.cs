using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kor
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

    class Henger : Kor
    {
        private int m;
        private double terfogat;
        private double felszín;

        public Henger() : base () { }

        public Henger( int r, int m,) : base(r) 
        {
            this.m = m;
        }

        public void setM(int m) { this.m = m; }

        public void setKor()
        {
            base.setKerulet();
            base.setTerulet();
        }

        public void setTerfogat()
        {
            this.terfogat = base.getTerulet() * this.m;
        }

        public void setFelszín()
        {
            this.felszín = base.getKerulet() * this.m + 2 * base.getTerulet();
        }

        public double getTerfogat() {  return this.terfogat; }
        public double getFelszín() { return this.felszín; }
    }
    internal class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine();
            Console.WriteLine("Henger példa");
            Henger h1 = new Henger(2, 5);
            h1.setKor();
            h1.setTerfogat();
            h1.setFelszín();

            Console.WriteLine($"Felszín: {h1.getFelszín()}, Terfogat: {h1.getTerfogat()}");

            Console.ReadKey();
        }

    }
}
