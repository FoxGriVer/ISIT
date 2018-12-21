using System;

namespace GeneticAlgorithmLab
{
    public class BLXCrossover
    {
        private double blxValue;

        public BLXCrossover(double blxValue)
        {
            this.blxValue = blxValue;
        }

        public Individual Do(Random rand, Individual parent1, Individual parent2)
        {
            var chCount = parent1.chCount;
            var descendant = new Individual(chCount);

            for (int j = 0; j < chCount; ++j)
            {
                double cMin = 0;
                double cMax = 0;

                double p1value = parent1.ch[j].value;
                double p2value = parent2.ch[j].value;

                if (p1value < p2value)
                {
                    cMin = p1value;
                    cMax = p2value;
                }
                else
                {
                    cMin = p2value;
                    cMax = p1value;
                }

                double det_k = cMax - cMin;
                double left = cMin - blxValue * det_k;
                double right = cMax + blxValue * det_k;
                double amp = right - left;
                
                double value = rand.NextDouble() * amp + left;

                descendant.ch[j].value = value;
            }
            
            return descendant;
        }

        public void Write()
        {
            Util.Log("Crossover type: BLX-a crossover.");
            Util.Log(String.Format("BLX value: {0:0.000000}", blxValue));
        }
    }
}
