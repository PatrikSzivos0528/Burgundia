using System;

namespace hazi4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < array.Length; ++i)
            {
                int y = array[i];
                int j = i - 1;
                while (j > -1 && y < array[j])
                {
                    array[j + 1] = array[j];
                    --j;
                }
                array[j + 1] = y;
            }
        }
    }
}
