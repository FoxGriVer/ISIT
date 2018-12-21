using System;
using System.Collections.Generic;

namespace GeneticAlgorithmLab
{
    public class Individual
    {
        public List<Gene> ch;
        public int chCount;
        public int lifeTime;
        public double estimateValue;

        public Individual(int chCount)
        {
            this.chCount = chCount;
            ch = new List<Gene>();

            for (int i = 0; i < chCount; ++i)
                ch.Add(new Gene(0));

            lifeTime = 0;
            estimateValue = 0;
        }

        public Individual(List<Gene> ch)
        {
            chCount = ch.Count;
            this.ch = new List<Gene>(ch);

            lifeTime = 0;
            estimateValue = 0;
        }
        
        public Individual(Individual ind)
        {
            ch = new List<Gene>(ind.ch);
            chCount = ind.chCount;

            lifeTime = 0;
            estimateValue = ind.estimateValue;
        }

        public void Generate(Random rand)
        {
            for (int j = 0; j < chCount; ++j)
                ch[j].Generate(rand);
        }

        public void Mutate(Random rand, double mutationMax, double mutationValue = 1.0)
        {
            for (int j = 0; j < chCount; ++j)
            {
                double randValue = rand.NextDouble();

                if (randValue <= mutationValue)
                {
                    ch[j].Mutate(rand, mutationMax);
                }
            }
        }

        public void Write(int indNumber)
        {
            Util.LogNoLine(String.Format("{0}.\t", indNumber + 1));

            for (int j = 0; j < chCount; ++j)
            {
                if (j == 0)
                    Util.LogNoLine(String.Format("{0:0.000000} ", ch[j].value));
                else
                    Util.LogNoLine(String.Format("{0:0.000000} ", Math.Exp(ch[j].value)));
            }
        
            Util.Log(String.Format("\t[{0:0.000000}]", 1 / estimateValue));
        }

        public double Estimate()
        {
            estimateValue = 0;
            
            foreach(var p in Util.pointList)
            {
                double diff = Math.Pow(Math.Log(p.Value) - (ch[0].value * p.Key + ch[1].value), 2);
                estimateValue += diff;
            }
            
            estimateValue = 1.0 / estimateValue;
            
            return estimateValue;
        }

        public void IncrementLifeTime()
        {
            ++lifeTime;
        }
    }
}
