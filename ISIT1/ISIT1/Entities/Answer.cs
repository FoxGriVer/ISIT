using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ISIT1.Entities
{
    [DataContract]
    public class Answer
    {
        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public double MinScore { get; set; }

        [DataMember]
        public double MaxScore { get; set; }

        public Answer(string text, double minScore, double maxScore)
        {
            Text = text;
            MinScore = minScore;
            MaxScore = maxScore;
        }
    }
}
