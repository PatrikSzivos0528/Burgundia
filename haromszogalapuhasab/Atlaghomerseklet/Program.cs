using System;
using System.Linq;


namespace Atlaghomerseklet
{
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

    internal class TemperatureMatrix
    {
        public TemperatureMatrix()
        {
        }

        internal void CalculateMonthlyAverages()
        {
            throw new NotImplementedException();
        }

        internal void GenerateRandomTemperatures()
        {
            throw new NotImplementedException();
        }
    }
}