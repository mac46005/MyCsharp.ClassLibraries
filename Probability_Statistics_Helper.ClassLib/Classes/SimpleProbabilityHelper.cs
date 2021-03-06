namespace Probability_Statistics_Helper.ClassLib.Classes{
    /// <summary>
    /// Probability Basics.
    /// Represents the equal likelihood model
    /// </summary>
    public class SimpleProbabilityHelper{



        /// <summary>
        /// Probability = f / N
        /// </summary>
        /// <param name="f">Number of ways event occurs</param>
        /// <param name="N">Total number of possible outcomes</param>
        /// <returns></returns>
        public static decimal SolveForP(decimal f,decimal N){
            return f / N;
        }

        /// <summary>
        /// Solves for f(The number of ways an event occurs)
        /// </summary>
        /// <param name="P">Probability</param>
        /// <param name="N">Total number of possible outcomes</param>
        /// <returns></returns>
        public static decimal SolveForF(decimal P,decimal N){
            return N * P;
        }

        /// <summary>
        /// Solve for N(Total number of outcomes)
        /// </summary>
        /// <param name="probability"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        public static decimal SolveForN(decimal probability,decimal f){
            return probability / f;
        }

        public static decimal ComplementationRule(decimal NOT_E){
            return 1 - NOT_E;
        }


        /// <summary>
        /// P(A OR B) = P(A) + P(B) - P(A & B)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static decimal GeneralAdditionRule(decimal A,decimal B){
            return (A + B) - (A * B);
        }

        


    }
}