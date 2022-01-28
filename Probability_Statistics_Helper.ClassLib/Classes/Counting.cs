using System.Collections.Generic;

namespace Probability_Statistics_Helper.ClassLib.Classes{
    public class Counting{




        public static decimal BCR(decimal[] set){
            decimal result = 0;

            for (int i = 0; i < set.Length; i++)
            {
                result *= set[i];
            }
            return result;
        }


        public static decimal Factorial(decimal number){
            decimal result = 0;
            for (int i = 1; i < number; i++)
            {
                result *= i;
            }
            return result;
        }

        /// <summary>
        /// mPr = m! / (m - r)!
        /// </summary>
        /// <param name="set"></param>
        public static void Permutation(List<decimal> set){

        }

        /// <summary>
        /// mCr = m! / r!(m - r)!
        /// </summary>
        /// <param name="set"></param>
        public static void CombinationRule(List<decimal> set){

        }

    }
}