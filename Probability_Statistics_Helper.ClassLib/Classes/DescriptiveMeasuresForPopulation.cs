using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probability_Statistics_Helper.ClassLib.Classes
{
    public class DescriptiveMeasuresForPopulation
    {

        private decimal _populationMean = 0;
        List<decimal> _populationDataSet;
        public DescriptiveMeasuresForPopulation(List<decimal> popDS)
        {
            popDS.Sort();
            _populationDataSet = popDS;
        }

        /// <summary>
        /// The mean of all possible observations for the entire population
        /// </summary>
        public void PopulationMean()
        {
            _populationMean = DescriptiveMeasures.MeasuresOfCenter.Mean(_populationDataSet);
            Console.WriteLine($"Population Mean");
            Console.WriteLine($"{_populationDataSet.Sum()} / {_populationDataSet.Count}");
            Console.WriteLine($"Mean Result:{_populationMean}");
        }

        public void FinitePopulationStandardDeviation()
        {
            List<decimal> squaredPopList = SquaredList(_populationDataSet);
            decimal squaredMean = _populationMean * _populationMean;

            decimal sumOfSquaredPopList = squaredPopList.Sum();
            decimal divideByPopAndSumSP = sumOfSquaredPopList / _populationDataSet.Count;
            decimal substractBySquaredMean = divideByPopAndSumSP - squaredMean;
            double result = Math.Sqrt((double)substractBySquaredMean);
            Console.WriteLine(nameof(FinitePopulationStandardDeviation) + " Result: " + result);

        }

        public List<decimal> SquaredList(List<decimal> list)
        {
            List<decimal> squaredList = new List<decimal>();
            for (int i = 0; i < list.Count; i++)
            {
                squaredList.Add(list[i] * list[i]);
            }
            return squaredList;
        }


        public decimal SqrRootDecimal(decimal square)
        {
            if (square < 0) return 0;

            decimal root = square / 3;
            int i;
            for (i = 0; i < 32; i++)
                root = (root + square / root) / 2;
            return root;
        }
    }
}
