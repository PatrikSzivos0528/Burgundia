using System;

namespace hazi2
{
    class Program
    {
        static void Main(string[] args)
        {
            int islandCount = 0;
            int maxIsIslandLenght = 0;
            int i = 0;

            while (i < data.Lenght)
            {
                if (data[i] == '1')
                {
                    ++islandCount;
                    int j = i;
                    int tmp = 0;

                    while (j < data.Length && data[j] == '1')
                    {
                        ++j;
                        ++tmp;
                    }
                    i = j;

                    if (tmp > maxIslandLength) { maxIslandLength = tmp; }

                }
                else
                {
                    ++i;
                }
            }
        }
    }
}
