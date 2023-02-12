using System;

namespace penzermek
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Add meg az osszeget: ");

            int a = Convert.ToInt32(Console.ReadLine());

            int ermek = 0;

            bool done = false;
            while (!done)
            {
                if(a % 200 != 0 && a/200 >= 1)
                {
                    ermek++;
                    a -= 200;
                }
                else if (a % 100 != 0 && a / 100 >= 1)
                {
                    ermek++;
                    a -= 100;
                }
                else if (a % 50 != 0 && a / 50 >= 1)
                {
                    ermek++;
                    a -= 50;
                }
                else if (a % 20 != 0 && a / 20 >= 1)
                {
                    ermek++;
                    a -= 20;
                }
                else if (a % 10 != 0 && a / 10 >= 1)
                {
                    ermek++;
                    a -= 10;
                }
                else if (a % 5 != 0 && a / 5 >= 1)
                {
                    ermek++;
                    a -= 5;
                }
                else if (a % 2 != 0 && a / 2 >= 1)
                {
                    ermek++;
                    a -= 2;
                }
                else
                {
                    ermek++;
                    done = !done;
                    a--;
                }
                
            }
            Console.WriteLine(ermek);
            Console.ReadKey();
        }
        
    }
}