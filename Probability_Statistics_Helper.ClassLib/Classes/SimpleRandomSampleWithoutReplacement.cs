using System.Collections.Generic;
/// <summary>
/// 
/// </summary>
namespace Probability_Statistics_Helper.ClassLib.Classes{
    public class SimpleRandomSampleWithoutReplacement{

        int _sampleSize;

        List<object> _population;
        public List<List<object>> Samples { get; private set; }
        public SimpleRandomSampleWithoutReplacement(List<object> population,int sampleSize)
        {
            _population = population;
        }

        private void SetSamples(){
            int current = 0;
            int count = 0;
            object currentObject = _population[0];
            while (true)
            {
                foreach (var item in _population)
                {
                    
                }
            }
        }
        private bool CheckDuplicate(List<object> sample,List<object> samples){
            if(sample.Equals(samples)){
                return true;
            }
            else{
                return false;
            }
        }


    }
}