using System;
using System.Collections.Generic;
using System.Linq;
using Probability_Statistics_Helper.ClassLib.Classes;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> dataSet = new List<decimal>{
                .495m,.225m,.024m,.025m,.231m
            };


            /// <summary>
            /// 
            /// P = f / N
            /// 
            /// </summary>
            /// <returns></returns>
            // decimal sum = dataSet.Sum();

            // decimal women = 76;
            // decimal total = 95;

            


            // Console.WriteLine(SimpleProbabilityHelper.SolveForP((13/52),(12/))));







            //decimal mean = DescriptiveMeasures.MeasuresOfCenter.Mean(dataSetDecimal);
            //decimal median = DescriptiveMeasures.MeasuresOfCenter.Median(dataSetDecimal.ToArray());

            //dataSetDecimal.ForEach(o => Console.Write(o + ", "));
            //Console.WriteLine();
            //Console.WriteLine($"Mean: {mean}");
            //Console.WriteLine($"Median: {median}");
            //Dictionary<decimal, int> mode = DescriptiveMeasures.MeasuresOfCenter.Mode(dataSetDecimal.ToArray());
            //foreach (var item in mode)
            //{
            //    Console.WriteLine(item);
            //}


            //DescriptiveMeasures.SampleStandardDeviation(dataSetDecimal.ToArray());
            //decimal range = DescriptiveMeasures.MeasureOfVariations.Range(dataSetDecimal.ToArray());
            //Console.WriteLine($"Range: {range}");


            //BoxPlot boxPlot = new BoxPlot(dataSetDouble);
            //boxPlot.PrintResult();


            // DescriptiveMeasuresForPopulation descriptiveMeasuresForPopulation = new DescriptiveMeasuresForPopulation(dataSetDecimal);
            // descriptiveMeasuresForPopulation.PopulationMean();
            // descriptiveMeasuresForPopulation.FinitePopulationStandardDeviation();

            decimal factorial = Counting.Factorial(69);
            Console.WriteLine(factorial);

            //20,748,024 /24
            Console.ReadKey();
        }
        public static decimal Divide(decimal x,decimal y) => x/y;
        public static decimal Middle(decimal x, decimal y) => (decimal)((x + y) / 2);

        
    }
}
