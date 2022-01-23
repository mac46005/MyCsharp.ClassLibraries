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
            List<double> dataSetDouble = new List<double> { 4,
7,
3,
2,
10,
0,
1,
5,
6,
4,
7,
6};
            List<decimal> dataSetDecimal = new List<decimal> { 2,3,0,3
            };
            dataSetDouble.Sort();
            dataSetDecimal.Sort();









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


            DescriptiveMeasuresForPopulation descriptiveMeasuresForPopulation = new DescriptiveMeasuresForPopulation(dataSetDecimal);
            descriptiveMeasuresForPopulation.PopulationMean();
            descriptiveMeasuresForPopulation.FinitePopulationStandardDeviation();

            Console.ReadKey();
        }


        public static decimal Middle(decimal x, decimal y) => (decimal)((x + y) / 2);


    }
}
