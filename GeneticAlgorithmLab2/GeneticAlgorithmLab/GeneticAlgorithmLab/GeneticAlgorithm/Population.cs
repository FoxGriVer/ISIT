using System;
using System.Collections.Generic;

namespace GeneticAlgorithmLab
{
    public class Population
    {
        private List<Individual> individs;
        private List<Individual> bestIndivids;
        private List<Individual> descIndivids;

        private int indCount;
        private int chCount;
        private int indLifeTime;
        private double crossbreedValue;
        private double mutationValue;
        private double mutationMax;
        private double sameGeneProp;
        private double sameGeneDiv;
        private int generationNumber;

        private Random rand;

        public Individual bestIndivid;
        private double estimateSum;
        private int estimateMaxInd;
        private int estimateMaxGen;
        private double estimateMax;
        private int estimateAverGen;
        private double estimateAver;

        private SelectionType selectionType;
        private TournamentSelection tournamentCl;

        private CrossoverType crossoverType;
        private BLXCrossover blxCrossoverCl;
        
        public Population(int indCount, int chCount, int indLifeTime, double crossbreedValue, double mutationValue, double mutationMax, double sameGeneProp, double sameGeneDiv, int generationNumber)
        {
            rand = new Random();

            estimateSum = 0;
            estimateMaxInd = 0;
            estimateMaxGen = 0;
            estimateMax = 0;
            estimateAverGen = 0;
            estimateAver = 0;

            bestIndivid = new Individual(chCount);

            this.indCount = indCount;
            this.chCount = chCount;
            this.indLifeTime = indLifeTime;
            this.crossbreedValue = crossbreedValue;
            this.mutationValue = mutationValue;
            this.mutationMax = mutationMax;
            this.sameGeneProp = sameGeneProp;
            this.sameGeneDiv = sameGeneDiv;
            this.generationNumber = generationNumber;

            Generate();
        }
        
        private void Generate()
        {
            individs = new List<Individual>();
            bestIndivids = new List<Individual>();
            descIndivids = new List<Individual>();

            for (int i = 0; i < indCount; ++i)
                individs.Add(new Individual(chCount));

            for (int i = 0; i < indCount; ++i)
                individs[i].Generate(rand);
        }


        public void InitTournamentSelection(int tourNumber)
        {
            selectionType = SelectionType.Tournament;
            tournamentCl = new TournamentSelection(tourNumber);
        }

        public void InitBLXCrossover(double blxValue)
        {
            blxCrossoverCl = new BLXCrossover(blxValue);
            crossoverType = CrossoverType.BLXCrossover;
        }     

        public void Do()
        { 
            WriteFullData();

            DoEstimate(0);

            for (int i = 0; i < generationNumber; ++i)
            {
                DoGeneration(i);
            }
        }

        public void DoGeneration(int genIndex)
        {
            DoSelection();
            DoCrossbreed();
            DoMutation();
            DoSameIndividsDeletion();
            DoEstimate(genIndex);

            if(genIndex == (generationNumber - 1))
                WriteGenerationData(genIndex);
        }
        
        public void DoSelection()
        {
            bestIndivids = tournamentCl.Do(individs, indCount);
        }

        public void DoCrossbreed()
        {
            descIndivids.Clear();
            
            while (descIndivids.Count < indCount)
            {
                int i = (int)(indCount * rand.NextDouble());
                int j = (int)(indCount * rand.NextDouble());

                while (bestIndivids[i] == bestIndivids[j])
                {
                    j = (int)(indCount * rand.NextDouble());
                }

                double randValue = rand.NextDouble();

                if (randValue <= crossbreedValue)
                {
                    for (int r = 0; r < 2; ++r)
                    {
                        Individual descendant = new Individual(chCount);
                        descendant = blxCrossoverCl.Do(rand, bestIndivids[i], bestIndivids[j]);            
                        descIndivids.Add(descendant);
                    }
                }
                else
                {
                    descIndivids.Add(new Individual(bestIndivids[i]));
                    descIndivids.Add(new Individual(bestIndivids[j]));
                }
            }
        }

        public void DoMutation()
        {
            for (int i = 0; i < indCount; ++i)
            {
                descIndivids[i].Mutate(rand, mutationMax, mutationValue);
            }
        }

        public void DoSameIndividsDeletion()
        {
            var indState = new bool[indCount];
            int sameGeneCount = (int)(sameGeneProp * chCount);

            for (int i = 0; i < indCount; ++i)
            {
                if (!indState[i])
                {
                    for (int j = i + 1; j < indCount; ++j)
                    {
                        if (!indState[j])
                        {
                            int tempSameGeneCount = 0;

                            for (int r = 0; r < chCount; ++r)
                            {
                                if (Math.Abs((double)descIndivids[i].ch[r].value - (double)descIndivids[j].ch[r].value) < sameGeneDiv)
                                {
                                    ++tempSameGeneCount;
                                }
                            }
                            
                            if (tempSameGeneCount >= sameGeneCount)
                            {
                                indState[j] = true;
                            }
                        }
                    }
                }
            }

            for(int i = 0; i < indCount; ++i)
            {
                if(indState[i])
                {
                    descIndivids[i].Mutate(rand, mutationMax);
                }
            }
        }
        
        public void DoEstimate(int genIndex)
        {
            individs.AddRange(descIndivids);

            for (int i = 0; i < individs.Count; ++i)
            {
                individs[i].Estimate();
            }

            int j = 0;

            while (j < individs.Count)
            {
                if (individs[j].lifeTime >= indLifeTime)
                    individs.RemoveAt(j);
                else
                    ++j;
            }
            
            individs.Sort((x, y) => -x.estimateValue.CompareTo(y.estimateValue));
            
            if (individs.Count >= indCount)
            {
                individs.RemoveRange(indCount, individs.Count - indCount);
            }

            estimateSum = 0;
            
            for (int i = 0; i < indCount; ++i)
            {
                double estimate = individs[i].estimateValue;

                if (estimate >= estimateMax)
                {
                    estimateMax = estimate;
                    estimateMaxInd = i;
                    estimateMaxGen = genIndex;
                    bestIndivid = new Individual(individs[estimateMaxInd]);
                }

                estimateSum += estimate;
            }

            double estimateAverTemp = estimateSum / indCount;

            if(estimateAverTemp >= estimateAver)
            {
                estimateAver = estimateAverTemp;
                estimateAverGen = genIndex;
            }

            for (int i = 0; i < individs.Count; ++i)
            {
                individs[i].IncrementLifeTime();
            }
        }

        public void WriteFullData()
        {                  
            tournamentCl.Write();
        }

        public void WriteGenerationData(int ind)
        {
            Util.Log(String.Format("\n\t Число поколений {0}.", ind + 1));
            //Util.Log(String.Format("\tBest average value: \t{0:0.000000} [{1}]: ", 1 / estimateAver, estimateAverGen));
            //Util.Log(String.Format("\tBest ever value: \t{0:0.000000} [{1}]: ", 1 / estimateMax, estimateMaxGen));

            for (int i = 0; i < indCount; ++i)
            {
                individs[i].Write(i);
            }
        }
    }
}
