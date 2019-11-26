using ClassificationAlgorithmsDataMining1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassificationAlgorithms.DataSetup
{
    public class DataSetup
    {
        /// <summary>
        /// Prepares data for calculations.
        /// </summary>
        /// <param name="selectColumns"> selected data columns </param>
        /// <param name="classColumn"> selected class column </param>
        /// <param name="inputData"> input data from file</param>
        /// <returns>data - prepared data</returns>
        public static List<CustomDataElement> SetUpData(List<string> inputData, string[] selectColumns, string classColumn)
        {
            List<CustomDataElement> data = new List<CustomDataElement>();

            for (int i = 1; i < inputData.Count; i++)
            {
                var line = inputData[i];

                var elements = Regex.Split(line, Parameter.RegexSplitParam);

                List<double> parameter = new List<double>();

                String type = null;

                for (int j = 0; j < line.Length; j++)
                {
                    var jj = j + 1;
                    if (selectColumns.Any(t => int.Parse(t).Equals(jj)))
                    {
                        parameter.Add(double.Parse(elements[j].Replace("\"", "")));
                    }
                    else if (int.Parse(classColumn).Equals(jj))
                    {
                        type = elements[j];
                    }
                }

                data.Add(new CustomDataElement { Elements = parameter, Type = type });
            }
            return data;
        }
    }
}
