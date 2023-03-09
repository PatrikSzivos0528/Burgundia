using System;
using System.Linq;


namespace Atlaghomerseklet
{
    internal class homerseklet
    {
        class Month
        {
            private int[] _temperatures;

            public Month()
            {
                _temperatures = new int[30];
            }

            public int[] Temperatures
            {
                get { return _temperatures; }
            }

            public double AverageTemperature
            {
                get { return (double)_temperatures.Sum() / 30; }
            }
        }

        class TemperatureMatrix
        {
            private Month[] _months;
            private double[] _monthlyAverages;

            public TemperatureMatrix()
            {
                _months = new Month[12];
                _monthlyAverages = new double[12];

                for (int i = 0; i < 12; i++)
                {
                    _months[i] = new Month();
                }
            }

            public Month[] Months
            {
                get { return _months; }
            }

            public double[] GetMonthlyAverages()
            { return _monthlyAverages; }

            public double[] MonthlyAverages
            {
                get { return _monthlyAverages; }
            }

            public void GenerateRandomTemperatures()
            {
                Random rand = new Random();

                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 30; j++)
                    {
                        _months[i].Temperatures[j] = rand.Next(-10, 15);
                    }
                }
            }

            public void CalculateMonthlyAverages()
            {
                for (int i = 0; i < 12; i++)
                {
                    _monthlyAverages[i] = _months[i].AverageTemperature;
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                TemperatureMatrix temperatureMatrix = new TemperatureMatrix();
                temperatureMatrix.GenerateRandomTemperatures();
                temperatureMatrix.CalculateMonthlyAverages();

                Console.WriteLine("A 12 hónap átlaghőmérsékletei:");
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine("{0}. hónap: {1:0.00} fok",
                        i + 1,
                        temperatureMatrix.MonthlyAverages[i]);
                }
                Console.ReadLine();
            }

        }
    }
}