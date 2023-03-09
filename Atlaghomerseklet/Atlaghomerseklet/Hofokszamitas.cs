using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Atlaghomerseklet
{
    struct NapiAdat
    {
        public string honap;    //Honap neve
        public int nap;         //Nap sorszama
        public double hofok;       //Napi homerseklet
    }
    struct HaviAdat
    {
        public string honap;    //Honap neve
        public int hofok;       //Honap atlaghomerseklete
    }

    internal class Hofokszamitas
    {
        //Osztályváltozó
        private int[,] adat; //hofok tarolas
        private int[] haviAtlag = new int[12];
        private NapiAdat napiMax, napiMin;
        private HaviAdat haviMax, haviMin;
        private NapiAdat[] otMinusz = new NapiAdat[5];

        static string[] honapok = {"Január", "Február", "Március", "Április", "Május", "Június", "Július", "Augusztus", "Szeptember", "Oktober", "November", "December" };

        //Konstruktor
        Hofokszamitas(int[,] p) { this.adat = p; }

        //Eredmenyeket atado metodusok
        public NapiAdat getNapiMin() { return napiMin; }
        public NapiAdat getNapiMax() { return napiMax; }
        public HaviAdat getHaviMax() { return haviMax; }
        public HaviAdat getHaviMin() { return haviMin; }
        public NapiAdat[] getotMinusz() { return otMinusz; }
        //Számítások
        public void szamitas()
        {
            //Legmelegebb és leghidegebb napok kiszámolása
            setNapiMax();
            setNapiMin();
            //Legmelegebb és leghidegebb honap kiszámolása
            setHaviAtlag();
            setHaviMax();
            setHaviMin();
            //Folyamatos 5 minuszos nap kiszamitasa
            setOtMinusz();
        }

        private void setHaviAtlag()
        {
            int osszeg = 0;

            for (int i = 0; i < adat.GetLength(0); i++)
            {
                osszeg = 0;
                for (int j = 0; j < adat.GetLength(1); j++)
                {
                    osszeg += adat[i, j];

                    this.haviAtlag[i] = osszeg / adat.GetLength(1);
                }
            }
        }

        private void setOtMinusz()
        {
            int mDb = 0;

            for (int i = 0; i < adat.GetLength(0); i++)
            {
                for (int j = 0; j < adat.GetLength(1); j++)
                {
                    if (this.adat[i,j] < 0)
                    {
                        this.otMinusz[mDb].honap = honapok[i];
                        this.otMinusz[mDb].nap = j + 1;
                        this.otMinusz[mDb].hofok = this.adat[i,j];

                        mDb++;
                    }
                    else
                    {
                        for (int k = 0; k < mDb + 1; k++)
                        {
                            this.otMinusz[k].honap = String.Empty;
                            this.otMinusz[k].nap = 0;
                            this.otMinusz[k].hofok = 0;
                        }
                        mDb = 0;
                    }
                }
            }
        }

        private void setHaviMin()
        {
            int min = int.MaxValue,
                minInd = 0;

            for (int i = 0; i < this.haviAtlag.Length; i++)
            {
                if (this.haviAtlag[i] < min)
                {
                    min = this.haviAtlag[i];
                    minInd = i;
                }
            }

            this.haviMax.hofok = min;
            this.haviMax.honap = honapok[minInd];
        }

        private void setHaviMax()
        {
            int max = int.MinValue,
                maxInd = 0;

            for (int i = 0; i < this.haviAtlag.Length; i++)
            {
                if (this.haviAtlag[i] > max)
                {
                    max = this.haviAtlag[i];
                    maxInd = i;
                }
            }

            this.haviMax.hofok = max;
            this.haviMax.honap = honapok[maxInd];
        }

        private void setNapiMin()
        {
            int min = int.MaxValue,
                minI = 0, minJ = 0;
            for (int i = 0; i < adat.GetLength(0); i++)
            {
                for (int j = 0; j < adat.GetLength(1); j++)
                {
                    if (this.adat[i, j] < min)
                    {
                        min = this.adat[i, j];
                        minI = i;
                        minJ = j;
                    }
                }
            }
            //Eredmeny atadasa a tombnek
            this.napiMax.honap = honapok[minI];
            this.napiMax.nap = minJ + 1;
            this.napiMax.hofok = min;
        }

        private void setNapiMax()
        {
            int max = int.MinValue,
                maxI = 0, maxJ = 0;
            for (int i = 0; i < adat.GetLength(0); i++)
            {
                for (int j = 0; j < adat.GetLength(1); j++)
                {
                    if (this.adat[i,j] > max)
                    {
                        max = this.adat[i,j];
                        maxI = i;
                        maxJ = j;
                    }
                }
            }
            //Eredmeny atadasa a tombnek
            this.napiMax.honap = honapok[maxI];
            this.napiMax.nap = maxJ + 1;
            this.napiMax.hofok = max;
        }
    }
}
