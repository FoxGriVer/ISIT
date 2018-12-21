using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GeneticAlgorithmLab
{
    public enum SelectionType
    {
        None,
        Roulette,
        Tournament
    }

    public enum CrossoverType
    {
        None,
        BLXCrossover,
        ArithmeticCrossover
    }
    
    public static class Util
    {
        public static MainForm myForm;
        public static List<KeyValuePair<double, double>> pointList;

        public static string logString = "";

        public static string textBoxPointsDefault =
@"2,0 9,0
11,0 18,0";

        public static void SaveForm(MainForm form)
        {
            myForm = form;
        }

        public static List<KeyValuePair<double, double>> ReadPoints(string textBoxText, out bool errorFlag)
        {
            errorFlag = false;
            var myList = new List<KeyValuePair<double, double>>();

            var linesList = textBoxText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            if (linesList.Length > 0)
            {
                foreach (var l in linesList)
                {
                    var pointsList = l.Split(new string[] { " " }, StringSplitOptions.None);

                    if (pointsList.Length >= 2)
                    {
                        try
                        {
                            double pointX = double.Parse(pointsList[0]);
                            double pointY = double.Parse(pointsList[1]);

                            myList.Add(new KeyValuePair<double, double>(pointX, pointY));
                        }
                        catch (Exception)
                        {
                            errorFlag = true;
                        }
                    }
                    else
                        errorFlag = true;
                }
            }
            else
                errorFlag = true;

            return myList;
        }

        public static void LogClear()
        {
            myForm.textBoxLogText = "";
            
        }

        public static void Log(string logText)
        {
            myForm.textBoxLogText += logText + Environment.NewLine;
            logString += logText + Environment.NewLine;
            WriteInFileLine(logText);
        }

        public static void LogNoLine(string logText)
        {
            myForm.textBoxLogText += logText;
            logString += logText;
            WriteInFileNoLine(logText);
        }

        public static void WriteInFileLine(string text)
        {
            string writePath = @"C:\Users\MacPavel\Desktop\GeneticAlgorithmLab2\GeneticAlgorithmLab\GeneticAlgorithmLab\result.txt";            
            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(text);
            }
        }

        public static void WriteInFileNoLine(string text)
        {
            string writePath = @"C:\Users\MacPavel\Desktop\GeneticAlgorithmLab2\GeneticAlgorithmLab\GeneticAlgorithmLab\result.txt";
            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            {
                sw.Write(text);
            }
        }
    }
}
