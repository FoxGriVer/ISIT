using System;
using System.Collections.Generic;

namespace GeneticAlgorithmLab
{ 
    public class TournamentSelection
    {
        public int tourNumber;

        public TournamentSelection(int tourNumber)
        {
            this.tourNumber = tourNumber;
        }

        public List<Individual> Do(List<Individual> individs, int indCount)
        {
            List<Individual> selectedIndivids = new List<Individual>();
            List<Individual> initalIndivids = new List<Individual>(individs);
            Random rand = new Random();

            for (int i = 0; i < indCount; ++i)
            {
                List<Individual> tournamentIndivids = new List<Individual>();
                List<Individual> initialTempIndivids = new List<Individual>(initalIndivids);
                
                for (int j = 0; j < tourNumber; ++j)
                {
                    int n = rand.Next(initialTempIndivids.Count);
                    tournamentIndivids.Add(initialTempIndivids[n]);
                    initialTempIndivids.RemoveAt(n);
                }

                double maxValue = 0;
                Individual fittest = new Individual(tournamentIndivids[0].chCount);

                foreach (var ind in tournamentIndivids)
                {
                    if (ind.estimateValue > maxValue)
                    {
                        maxValue = ind.estimateValue;
                        fittest = ind;
                    }
                }
                
                selectedIndivids.Add(fittest);
            }

            return selectedIndivids;
        }

        public void Write()
        {
            Util.Log(String.Format("                Параметр селекции: {0}", tourNumber));
        }
    }
}
