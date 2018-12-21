using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsitLab3.Entities;

namespace IsitLab3
{
    public class Utilities
    {
        static private string filePath = @"C:\Users\MacPavel\source\repos\IsitLab3\IsitLab3\table.txt";

        static public List<TableParameter> DownloadTableFromFile()
        {
            List<TableParameter> tableParameters;
            using (StreamReader sr = new StreamReader(filePath, System.Text.Encoding.Default))
            {
                string line = "";
                tableParameters = new List<TableParameter>();

                while ((line = sr.ReadLine()) != null)
                {
                    tableParameters.Add(ParseTable(line));
                }
                return tableParameters;
            }
        }

        static private TableParameter ParseTable(string tableRow)
        {            
            string rowNumber = tableRow.Split(new char[] { '.' })[0];
            string parametersRow = tableRow.Split(new char[] { '.' })[1];

            string[] parameters = parametersRow.Split(new char[] { '/' });
            string classOfRow = parameters[2].Split(new char[] { '=' })[1];

            parameters[2] = parameters[2].Split(new char[] { '=' })[0];

            TableParameter tableParameter = new TableParameter()
            {
                Id = Int32.Parse(rowNumber),
                Parameter1 = Int32.Parse(parameters[0]),
                Parameter2 = Int32.Parse(parameters[1]),
                Parameter3 = Int32.Parse(parameters[2]),
                ParameterClass = Int32.Parse(classOfRow),
            };

            return tableParameter;
        }




        static public int ParseResultTableFromFile(int param1, int param2, int param3)
        {
            int tableResult = 0;
            if(param1 == 1 && param2 == 1 && param3 == 0)
            {
                tableResult = 1;
            }
            if (param1 == 1 && param2 == 0 && param3 == 1)
            {
                tableResult = 1;
            }
            if (param1 == 0 && param2 == 1 && param3 == 1)
            {
                tableResult = 2;
            }
            if (param1 == 0 && param2 == 1 && param3 == 0)
            {
                tableResult = 3;
            }
            if (param1 == 0 && param2 == 1 && param3 == 1)
            {
                tableResult = 2;
            }
            if (param1 == 0 && param2 == 0 && param3 == 1)
            {
                tableResult = 3;
            }
            if (param1 == 1 && param2 == 0 && param3 == 0)
            {
                tableResult = 1;
            }
            if (param1 == 1 && param2 == 1 && param3 == 1)
            {
                tableResult = 1;
            }
            if (param1 == 0 && param2 == 0 && param3 == 0)
            {
                tableResult = 2;
            }
            return tableResult;
        }

    }
}
