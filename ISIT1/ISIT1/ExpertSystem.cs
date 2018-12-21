using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ISIT1.Entities;

namespace ISIT1
{
    public class ExpertSystem
    {
        private static ExpertSystem instance;

        private static Mutex mutexObj = new Mutex();

        private ExpertSystem()
        {

        }

        public static ExpertSystem GetExpertSystem()
        {
            mutexObj.WaitOne();
            if (instance == null)
            {
                instance = new ExpertSystem();
            }
            mutexObj.ReleaseMutex();

            return instance;
        }

        public string FindAppropriateWebTechnology(Dictionary<string, int> _dictionary, Answer[] _answers)
        {
            double resultScore = CountShortlif(_dictionary);
            return CorrelateScoreWithAnswer(_answers, resultScore);
        }

        private double CountShortlif(Dictionary<string, int> _dictionary)
        {
            double maxScore = -1.0;
            double tmpScore = 0.0;
            foreach (KeyValuePair<string, int> keyValue in _dictionary)
            {
                double valueInThisIteretion = keyValue.Value / 25.0;
                tmpScore = tmpScore + valueInThisIteretion * (1.0 - tmpScore);

                if (tmpScore > maxScore)
                {
                    maxScore = tmpScore;
                }
            }
            return maxScore;
        }

        private string CorrelateScoreWithAnswer(Answer[] _answers, double _resultScore)
        {
            //немного непроизводительно, но за-то кратко
            foreach(Answer ans in _answers)
            {
                if(_resultScore > ans.MinScore && _resultScore <= ans.MaxScore)
                {
                    return String.Format("Вашему проекту наиболее всего соответсвует {0}", ans.Text);
                }                
            }
            return "";
        }

    }
}
