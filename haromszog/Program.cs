using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_teglalap
{
    internal class Program
    {
        class Teglalap 
        { 
            private int a ; private int b;
            public Teglalap(int a, int b)
            {
                this.a = a;
                this.b = b;

            }
           

            public int terulet() 
            {
                return(this.a*this.b);
            } 
            public int kerulet()
            {
                return(2*(this.a+this.b));
            }

            public Teglalap() { }
            public void setA(int a) { this.a = a; }
            public void setB(int b) { this.b = b; }

        }
       
        static void Main(string[] args)
        {

            Teglalap teglalap= new Teglalap();
            teglalap.setA(24);
            teglalap.setB(3);
            Console.WriteLine("A téglalap területe: {0}, kerülete: {1}",teglalap.terulet(),teglalap.kerulet());

            Teglalap teglalap2= new Teglalap(24,3);
            Console.WriteLine("A téglalap területe: {0}, kerülete: {1}", teglalap.terulet(), teglalap.kerulet());



            Console.ReadKey();
        }
    }
}
