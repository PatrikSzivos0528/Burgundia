using System;
using System.Text.RegularExpressions;

namespace hazi6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = @"^(\+)[1-9][0-9]{1,2}\s[1-9][0-9]{1,2}\s(\d{3}(-)){2}\d{3}$";
            Regex pattern = new Regex(s); string s1 = "+36 30 661-345-612";
            string s2 = "+3630 661-567-233";
            string s3 = "+56 30 667-876-987-456";
            Console.WriteLine(pattern.IsMatch(s1)); // true
            Console.WriteLine(pattern.IsMatch(s2)); // false
            Console.WriteLine(pattern.IsMatch(s3)); // false

            Console.ReadKey();
        }
    }
}
