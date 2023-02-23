using System;


namespace téglalap 
{ 
    class Rectangle
    {
        static void Main()
        {
        
            Console.Write("Add meg a téglalap 'a' oldalát: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg a téglalap 'b' oldalát: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

           
            Console.WriteLine("A téglalap területe: {0}", area);
            Console.WriteLine("A teglalap kerülete: {0}", perimeter);

            Console.ReadKey();
        }
    
    }
}
