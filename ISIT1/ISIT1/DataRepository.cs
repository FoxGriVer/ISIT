using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using System.Threading;
using ISIT1.Entities;

namespace ISIT1
{
    public class DataRepository
    {
        private static DataRepository instance;
        private string connectionRow;

        private static Mutex mutexObj = new Mutex();
        private DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Answer[]));

        private DataRepository()
        {
            connectionRow = @"C:\Users\MacPavel\source\repos\ISIT1\ISIT1\ExpertData.json";
        }

        public static DataRepository GetInstance()
        {
            mutexObj.WaitOne();
            if(instance ==null)
            {
                instance = new DataRepository();
            }
            mutexObj.ReleaseMutex();

            return instance;
        }

        private void WriteData()
        {
            Answer answerHtmlAndCSS = new Answer("Html, Css, JQuery", 0, 0.4);
            Answer answerReact = new Answer("React", 0.4, 0.6);
            Answer answerAngular = new Answer("AngularJS", 0.6, 0.7);
            Answer answerNodeJS = new Answer("NodeJS", 0.7, 0.85);
            Answer answerAspDotNet = new Answer("ASP.NET", 0.85, 1);

            Answer[] answers = new Answer[] { answerHtmlAndCSS,answerReact, answerAngular, answerNodeJS, answerAspDotNet };

            using (FileStream fileStream = new FileStream(connectionRow, FileMode.OpenOrCreate))
            {
                jsonSerializer.WriteObject(fileStream, answers);
            }
        }

        public List<string> GetEditedAnswers()
        {
            using (FileStream fileStream = new FileStream(connectionRow, FileMode.OpenOrCreate))
            {
                Answer[] answers = (Answer[])jsonSerializer.ReadObject(fileStream);
                List<string> editedAnswers = new List<string>();

                foreach(Answer ans in answers)
                {
                    editedAnswers.Add(String.Format("Вашему проекту наиболее всего соответсвует {0}", ans.Text));
                }
                return editedAnswers;
            }                
        }

        public Answer[] GetAnswers()
        {
            using (FileStream fileStream = new FileStream(connectionRow, FileMode.OpenOrCreate))
            {
                Answer[] answers = (Answer[])jsonSerializer.ReadObject(fileStream);
                return answers;
            }
        }


    }
}
