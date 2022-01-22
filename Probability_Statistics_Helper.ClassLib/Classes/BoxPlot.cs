using System;
using System.Collections.Generic;

namespace Probability_Statistics_Helper.ClassLib.Classes
{
    public class Quartile
    {

        private List<double> _dataSet;

        public Quartile(List<double> dataSet)
        {
            dataSet.Sort();
            _dataSet = dataSet;

            List<double> top = dataSet.GetRange(dataSet.Count / 2, (dataSet.Count / 2));
            List<double> bottom = dataSet.GetRange(0, (dataSet.Count / 2));

            top.Sort();
            bottom.Sort();


            Q2 = MedianOfList(dataSet);
            Q1 = MedianOfList(bottom);
            Q3 = MedianOfList(top);
            ProcessIQR();
        }

        public double Q1 { get; private set; }
        public double Q2 { get; private set; }
        public double Q3 { get; private set; }
        public double IQR { get; private set; }



        private double MedianOfList(List<double> dataSet)
        {
            double result = 0;


            int length = dataSet.Count;
            double mid_D = (length / 2);
            int mid_I = length / 2;



            if ((double)mid_I == mid_D)
            {
                double o1 = dataSet[mid_I - 1];
                double o2 = dataSet[mid_I];

                result = (o1 + o2) / 2;
            }
            else
            {
                result = dataSet[mid_I];
            }


            return result;
        }


        private void ProcessIQR()
        {
            IQR = Q3 - Q1;
        }
        private void Outliers()
        {
            double lowerLimit = Q1 - 1.5 * IQR;
            double upperLimit = Q3 + 1.5 * IQR;
            Console.WriteLine($"Potential Outliers: {lowerLimit},{upperLimit}");
        }

        private void Interpretation()
        {
            Console.WriteLine($"Interpretation:\n25% less than {Q1};\n25% between {Q1} - {Q2};\n25% between {Q2} - {Q3};\n25% - 100% is greater than {Q3}");
        }

        public void PrintResult()
        {
            Console.WriteLine("Quartile\n");
            Console.WriteLine("DataSet:");
            _dataSet.ForEach(o => Console.Write(o + ", "));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Q1:{Q1}\nQ2:{Q2}\nQ3:{Q3}\n\nIQR:{IQR} <= Represents 50% of average data\n\n\n");
            Interpretation();
            Console.WriteLine($"\nFive Number Summary: {_dataSet[0]},{Q1},{Q2},{Q3},{_dataSet[_dataSet.Count - 1]}");
            
            
            
            Outliers();

        }
    }
}