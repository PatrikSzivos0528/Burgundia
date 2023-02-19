using System;
using System.Text.RegularExpressions;

namespace hazi5
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex("^[1-9][0-9]*");
            string s1 = "012345";
            string s2 = "112345";
            string s3 = "2";
            Console.WriteLine("{0} : {1}", s1, (pattern.IsMatch(s1) ?
                "természetes szám" : "nem természetes szám"));
            Console.WriteLine("{0} : {1}", s2, (pattern.IsMatch(s2) ?
                "természetes szám" : "nem természetes szám"));
            Console.WriteLine("{0} : {1}", s3, (pattern.IsMatch(s3) ?
                "természetes szám" : "nem természetes szám"));
            Console.ReadKey();
        }
    }
}
