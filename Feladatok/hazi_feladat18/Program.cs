using System;

class Program
{
    public static void Main()
    {
        Console.Write("a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        double vegeredmeny1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a;
        double vegeredmeny2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a;
        Console.WriteLine($"A két valós gyöke: x1 = {vegeredmeny1}, x2 = {vegeredmeny2}");
        Console.ReadKey();
    }
}