using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Probability_Statistics_Helper.ClassLib.Classes
{


    public class DescriptiveMeasures
    {



        /// <summary>
        /// Different methods of getting the center measures of a descriptive statistic
        /// </summary>
        public static class MeasuresOfCenter
        {

            /// <summary>
            /// Applies to quantitative data.
            /// The most common used measure of center.
            /// Is strogly effective with few large/small values in a Data Set
            /// </summary>
            /// <param name="dataSet">Collection of data</param>
            /// <returns>(SumOfDataSet/DataSet.Length)</returns>
            public static decimal Mean(List<decimal> dataSet)
            {
                decimal sum = dataSet.Sum();
                decimal meanResult = sum / dataSet.Count;
                return meanResult;
                
            }


            /// <summary>
            /// Applies to quantitative data
            /// The median of a data set is the number that divides the bottom 50%
            /// of the data from the top 50%.
            /// If the number of observations is even, then the median is the mean of the
            /// two middle obervations in the ordered list.
            /// If the number of observations odd, then the median is exactly in the middle
            /// of the ordered list.
            /// </summary>
            /// <param name="dataSet">The collection of observations</param>
            /// <returns>The Median result from the data set</returns>
            public static decimal Median(decimal[] dataSet){
                Array.Sort(dataSet);

                decimal[] middle;
                int dataSetSize = dataSet.Length;
                decimal dataSetMiddleDecimal = (decimal)((decimal)dataSetSize / 2);
                int dataSetMiddleInt = (int)(dataSetSize / 2);

                if(dataSetMiddleDecimal == (decimal)dataSetMiddleInt){
                    middle = new decimal[]{dataSet[dataSetMiddleInt - 1],dataSet[dataSetMiddleInt]};
                }
                else{
                    middle = new decimal[] {dataSet[dataSetMiddleInt]};
                }


                decimal result = 0;

                if(middle.Length > 1){
                    result = Mean(middle.ToList());
                }
                else{
                    result = middle[0];
                }

                return result;
            }

            /// <summary>
            /// Can be used with either Quantitative or Qualitative Data Sets
            /// 
            /// Finds the frequency if each value in the data set.
            /// - If no value occurs more than once then the data set has no mode
            /// - otherwise, any value that occurs with the greatest frequency is the mode
            /// of the data set.
            /// 
            /// This method returns the list of frequencys of all data sets not the
            /// result of the true mode of the data set...later implement its true intent.
            /// </summary>
            /// <param name="dataSet">The array to be checked for the mode</param>
            /// <returns>A dictionary of frequency for distinct values in a data set</returns>
            public static Dictionary<decimal,int> Mode(decimal[] dataSet){
                Array.Sort(dataSet);
                IEnumerable<decimal> distinctValues;
                distinctValues = dataSet.Distinct();

                Dictionary<decimal,int> distinctValueDic = new Dictionary<decimal, int>();
                foreach (var item in distinctValues)
                {
                    distinctValueDic.Add(item,0);
                }

                foreach (var item in dataSet)
                {
                    if(distinctValueDic.ContainsKey(item)){
                        distinctValueDic[item]++;
                    }
                }

                return distinctValueDic;

            }

        }


        /// <summary>
        /// 
        /// </summary>
        public static class MeasureOfVariations{

            /// <summary>
            /// 
            /// </summary>
            /// <param name="dataSet"></param>
            /// <returns></returns>
            public static decimal Range(decimal[] dataSet){
                Array.Sort(dataSet);
                decimal[] sorted = dataSet;
                decimal result = sorted[sorted.Length - 1] - sorted[0];

                return result;
            }
        }

        /// <summary>
        /// This will print to console...
        /// 
        /// Takes into account all the observations. It is the preferred measure of variation
        ///  the mean is used as the measure of center.
        /// It is more information-rich and helps to determine the shape of the distribution of the data.
        /// 
        /// Measures variations by indicating how far, on average, the observations will, on average,
        /// be far from the mean.
        /// </summary>
        /// <param name="dataSet">The data set to test and print</param>
        /// <returns>Prints the result to console of a table and result of a sample standard variation</returns>
        public static void SampleStandardDeviation(decimal[] dataSet)
        {
            Array.Sort(dataSet);

            //Find the mean of the dataSet
            decimal mean = MeasuresOfCenter.Mean(dataSet.ToList());

            //Find deviation for each dataset
            decimal[] deviationArray = new decimal[dataSet.Length];
            for (int i = 0; i < dataSet.Length; i++)
            {
                deviationArray[i] = dataSet[i] - mean;
            }


            // (x - mean)^2
            decimal[] sumOfSquaredDeviations = new decimal[dataSet.Length];
            for (int i = 0; i < dataSet.Length; i++)
            {

                sumOfSquaredDeviations[i] = deviationArray[i] * deviationArray[i];
            }

            for (int i = 0; i < dataSet.Length; i++)
            {
                Console.WriteLine($"{dataSet[i]}|{deviationArray[i]}|{sumOfSquaredDeviations[i]}");
            }


            decimal sumOfAllSquareDev = sumOfSquaredDeviations.Sum();
            decimal divideOverNumberOfObservations = sumOfAllSquareDev / (dataSet.Length - 1);
            double overallStandardDeviation = Math.Sqrt((double)divideOverNumberOfObservations);
            Console.WriteLine($"Standard Deviation: {overallStandardDeviation}");
        }
    }


}