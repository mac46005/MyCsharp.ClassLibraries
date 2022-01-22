using System;
using System.Collections.Generic;
using Probability_Statistics_Helper.ClassLib.Classes;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> dataSet = new List<double> { 68,
103,
141,
82,
160,
90,
153,
59,
165,
116};
            
            Quartile quartile = new Quartile(dataSet);
            quartile.PrintResult();
            Console.ReadKey();
        }


        public static decimal Middle(decimal x, decimal y) => (decimal)((x + y) / 2);
    }
}
