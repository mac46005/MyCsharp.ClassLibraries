using System.Collections.Generic;
using System.Diagnostics;

namespace Probability_Statistics_Helper.ClassLib.Classes{
    public class Quartile{
        private List<decimal> _dataSet;

        public Quartile(List<decimal> dataSet)
        {
            dataSet.Sort();
            _dataSet = dataSet;
        }




        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public decimal Q1 { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public decimal Q2 { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public decimal Q3 { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public decimal IQR { get; private set; }


        /// <summary>
        /// This lower limit determines
        /// is there is an outlier in the lower 50%
        /// in the dataset
        /// </summary>
        /// <value>lower limit</value>
        public decimal LowerLimit { get;private set; }

        /// <summary>
        /// This upper limit determines 
        /// is there is an outlier in the upper 50%
        /// in the dataset
        /// </summary>
        /// <value></value>
        public decimal UpperLimit { get; private set; }




        /// <summary>
        /// 
        /// </summary>
        private void ProcessIQR(){
            IQR = Q3 - Q1;
        }









        private void ProcessOutliers(){
            LowerLimit = Q1 - 1.5m * IQR;
            UpperLimit = Q3 + 1.5m * IQR;
        }

        private decimal MedianOfList(List<decimal> dataSet){
            decimal result = 0;

            int length = dataSet.Count;
            decimal mid_D = (decimal)((decimal)length / 2);
            int mid_I = length / 2;


            if((decimal)mid_I == mid_D){
                decimal o1 = dataSet[mid_I - 1];
                decimal o2 = dataSet[mid_I];

                result = (o1 + o2) / 2;
            }
            else{
                result = dataSet[mid_I];
            }
            return result;
        }




        private void Initialize(List<decimal> dataSet){

            List<decimal> top = dataSet.GetRange(dataSet.Count / 2,dataSet.Count / 2);
            List<decimal> bottom = dataSet.GetRange(0,dataSet.Count / 2);
        }
        private void Terminal(){
            Debug.WriteLine("");
        }
    }
}