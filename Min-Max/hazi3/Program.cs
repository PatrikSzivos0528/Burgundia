using System;

namespace hazi3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < array.Length - 1; ++i)
            {
                for (int j = array.Length - 1; j > i; --j)
                {
                    if (array[j - 1] > array[j])
                    {
                        int tmp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = tmp;
                    }
                }
            }
        }
    }
}
