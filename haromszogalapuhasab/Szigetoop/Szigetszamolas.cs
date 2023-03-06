using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szigetoop
{
    internal class Szigetszamolas
    {
        //osztályváltozok
        int islandCount = 0,
            maxIslandLenght = 0,
            i = 0;
        string data = string.Empty;

        //Konstruktor 
        public Szigetszamolas() { } 

        public Szigetszamolas(string data) 
        {
            this.data = data;
        }

        //metodusok 
        public void setData(string data) { this.data = data;}
        public string getData() { return this.data;}

        public int getIslandCount() { return this.islandCount;}

        public int getMaxIslandLenght() { return this.maxIslandLenght;}

        public void Szamol()
        {
            while (i < this.data.Length)
            {
                if (this.data[i] == '1')
                {
                    ++this.islandCount;
                    int j = i;
                    int tmp = 0; //sziget beljesét gyűjti
                    while (j < this.data.Length && this.data[j] == '1')
                    {
                        ++j;
                        ++tmp;
                    }
                    i = j;
                    if (tmp > this.maxIslandLenght) { this.maxIslandLenght = tmp; }
                }
                else
                {
                    ++i;
                }
            }
        }
    }
}
