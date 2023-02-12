using System;

class Program
{
    public static void Main()
    {
        Console.Write("Elso idopont: ");
        TimeSpan time1 = TimeSpan.Parse(Console.ReadLine());
        Console.Write("Masodik idopont: ");
        TimeSpan time2 = TimeSpan.Parse(Console.ReadLine());
        Console.WriteLine($"A kulonbseg: {-(time1 - time2).Seconds} masodperc");
        Console.ReadKey();
    }
}