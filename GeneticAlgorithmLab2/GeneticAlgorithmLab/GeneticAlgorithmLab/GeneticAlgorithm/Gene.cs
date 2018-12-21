using System;

namespace GeneticAlgorithmLab
{
    public class Gene
    {
        public double value;

        public Gene(double value)
        {
            this.value = value;
        }

        public void Generate(Random rand)
        {
            value = 10.24 * (rand.NextDouble() - 0.5);
        }

        public void Mutate(Random rand, double mutationMax)
        {
            value = value + mutationMax * (rand.NextDouble() - 0.5);
        }
    }
}
