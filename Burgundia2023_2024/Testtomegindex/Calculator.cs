using System;
using System.Collections.Generic;


namespace MyConsoleApp
{
    public class BmiCalc
    {
        private string nev, kategória, neme;
        private double bb, tb, bmi;
        //public double bb { get; set; }
        //public double tb { get; set; }


        public void InputGender()
        {
            int genderInt;
            do
            {
                try
                {
                    Console.WriteLine("Válassza ki a nemét:");
                    Console.WriteLine("1. Férfi");
                    Console.WriteLine("2. Nő");
                    Console.Write("\r\nLehetőségek: ");
                    genderInt = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Masukkan angka 1 atau 2");
                    continue;
                }
                break;
            } while (true);

            if (genderInt == 1)
            {
                neme = "Férfi";
            }
            else if (genderInt == 2)
            {
                neme = "Nő";
            }
            else
            {
                Console.WriteLine("Hibás bemenet");
                InputGender();
            }
        }

        public void InputBB()
        {
            Console.Write("Mennyi a súlyod? (kg-ban) ");
            try
            {
                bb = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Hibás bemenet");
                InputBB();
            }

        }

        public double GetBB()
        {
            return bb;
        }

        public void InputTB()
        {
            Console.Write("Milyen magas vagy? (cm-ben) ");
            try
            {
                tb = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Hibás bemenet ");
                InputTB();
            }

        }

        public double GetTB()
        {
            return tb;
        }

        public void InputNama()
        {
            do
            {
                try
                {
                    Console.Write("A neved?");
                    nev = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Hibás bemenet");
                    continue;
                }

                if (nev.Length > 15)
                {
                    Console.WriteLine("Maximum 15 betű");
                    continue;
                }

                if (String.IsNullOrWhiteSpace(nev))
                {
                    Console.WriteLine("A név nem lehet üres");
                    continue;
                }

                break;
            } while (true);
        }

        public string GetNama()
        {
            return nev;
        }

        public double GetBmi()
        {
            return bmi;
        }

        public void SetBmi(double bmiVal)
        {
            bmi = Math.Round(bmiVal, 2);
        }

        public double CalcBmi()
        {
            return bb / Math.Pow((tb / 100), 2);
        }

        public void SetKategori(string kategoriVal)
        {
            kategória = kategoriVal;
        }

        public string GetKategori()
        {
            return kategória;
        }

        public string DecideCategory()
        {
            switch (neme)
            {
                case "Férfi":
                    if (bmi < 17)
                    {
                        return "Alacsony";
                    }
                    else if (bmi <= 23)
                    {
                        return "Normál (ideális)";
                    }
                    else if (bmi <= 27)
                    {
                        return "Magas";
                    }
                    else if (bmi > 27)
                    {
                        return "Elhízott";
                    }
                    return "Kudarc";
                case "Nő":
                    if (bmi < 18)
                    {
                        return "Alacsony";
                    }
                    else if (bmi <= 25)
                    {
                        return "Normál (ideális)";
                    }
                    else if (bmi <= 27)
                    {
                        return "Magas";
                    }
                    else if (bmi > 27)
                    {
                        return "Elhízott";
                    }
                    return "Kudarc";
                default:
                    return "Kérjük, válassza ki az 1. vagy a 2. nemet";
            }
        }

        public void Print()
        {
            Console.WriteLine($"{nev,15} | {neme,10} | {tb,5} | {bb,5} | {bmi,5} | {kategória,14}");
        }

        public void PrintDetail()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("                Eredmények");
            Console.WriteLine("===================================");
            Console.WriteLine($"Halo {nev},");
            Console.WriteLine($"Berat badan     = {bb} Kg");
            Console.WriteLine($"Tinggi badan    = {tb} Cm");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"BMI             = {bmi}");
            Console.WriteLine($"Kategori        = {kategória}");
        }
    }
}