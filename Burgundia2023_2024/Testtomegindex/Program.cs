using System;
using System.Collections.Generic;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BmiCalc> histories = new List<BmiCalc>();

            bool street = true;
            while (street)
            {
                Console.Clear();
                Console.WriteLine("==========================================");
                Console.WriteLine("Üdvözöljük a BMI kalkulátor alkalmazásban!");
                Console.WriteLine("==========================================");
                Console.WriteLine("  Menü opciók :");
                Console.WriteLine("     1. Számítsa ki a BMI-jét");
                Console.WriteLine("     2. Számítási előzmények");
                Console.WriteLine("     3. Kilépés");
                Console.Write("Lehetőségek : ");
                int menuoptions;
                do
                {
                    try
                    {
                        menuoptions = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Írja be az 1-es, 2-es vagy 3-as számot");
                        continue;
                    }
                    break;
                } while (true);


                switch (menuoptions)
                {
                    case 1:
                        histories.Add(Count());
                        break;
                    case 2:
                        ShowHistories(histories);
                        break;
                    case 3:
                        street = false;
                        Console.Clear();
                        Console.WriteLine("Az alkalmazás leáll\r\n");
                        break;
                    default:
                        break;
                }
            }
        }

        public static BmiCalc Count()
        {
            BmiCalc bmiCalc = new BmiCalc();
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("           1. Számítsa ki a BMI-jét");
            Console.WriteLine("===================================");

            
            bmiCalc.InputNama();
            bmiCalc.InputGender();
            bmiCalc.InputBB();
            bmiCalc.InputTB();
            bmiCalc.SetBmi(bmiCalc.CalcBmi());
            bmiCalc.SetKategori(bmiCalc.DecideCategory());

            //Output
            bmiCalc.PrintDetail();

            Console.WriteLine("\nNyomjon meg bármit a visszalépéshez");
            Console.ReadKey();
            return bmiCalc;
        }

        public static void ShowHistories(List<BmiCalc> histories)
        {
            Console.Clear();
            Console.WriteLine("=========================");
            Console.WriteLine(" 2. Számítási előzmények");
            Console.WriteLine("=========================");
            Console.WriteLine($"No. |{"Nama",15} | {"Gender",10} | {"TB",5} | {"BB",5} | {"BMI",5} | {"Kategória\r\n",14}");
            int i = 0;
            foreach (BmiCalc history in histories)
            {
                i++;
                Console.Write($"{i}.  |"); history.Print();
            }
            Console.WriteLine("\nNyomjon meg bármit a visszalépéshez");
            Console.ReadKey();
        }
    }
}