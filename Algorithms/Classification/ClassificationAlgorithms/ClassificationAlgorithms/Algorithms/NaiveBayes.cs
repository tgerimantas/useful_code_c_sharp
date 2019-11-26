using System;
using System.Collections.Generic;
using System.Linq;
using ClassificationAlgorithms.DataSetup;
using ClassificationAlgorithmsDataMining1;

namespace NaiveBayes_A
{
    public class NaiveBayes
    {
        public NaiveBayes()
        {

        }


        /// <summary>
        /// Main calculation method. 
        /// </summary>
        /// <param name="testDataElement">new test object data</param>
        /// <param name="fileData">input data</param>
        /// <param name="selectColumns">selected data column numbers</param>
        /// <param name="classColumn">class column number</param>
        /// <returns></returns>
        public string Calculate(CustomDataElement testDataElement, List<string> fileData, string[] selectColumns, string classColumn)
        {
            var data = DataSetup.SetUpData(fileData, selectColumns, classColumn);

            var classDictionary = SeparateData(data);

            var summary = GetClassSummary(classDictionary);

            var probabilities = GetProbabilities(summary, testDataElement);

            var prediction = GetPrediction(probabilities);

            return prediction.Key;
        }

        /// <summary>
        /// Finds maximum probability
        /// </summary>
        /// <param name="probabilities">probabilities</param>
        /// <returns>selectedItem</returns>
        private KeyValuePair<string, double> GetPrediction(Dictionary<string, double> probabilities)
        {
            var maxProbability = 0.0;
            KeyValuePair<string, double> selectedItem = new KeyValuePair<string, double>();

            foreach (var item in probabilities)
            {
                if (maxProbability < item.Value)
                {
                    maxProbability = item.Value;
                    selectedItem = item;
                }
            }
            return selectedItem;
        }


        /// <summary>
        /// Calculates every class probability by new test object
        /// </summary>
        /// <param name="summary">list</param>
        /// <param name="testDataElement"> new test object parameters </param>
        /// <returns>probabilities</returns>
        private Dictionary<string, double> GetProbabilities(Dictionary<string, List<SummaryListElement>> summary, CustomDataElement testDataElement)
        {
            Dictionary<string, double> probabilities = new Dictionary<string, double>();

            foreach (var summaryItem in summary)
            {
                probabilities.Add(summaryItem.Key, 1);

                for (int i = 0; i < summaryItem.Value.Count; i++)
                {
                    var item = summaryItem.Value[i];
                    var testItemElement = testDataElement.Elements[i];

                    var prob = CalculateProbability(item, testItemElement);
                    if (!prob.Equals(0))
                    {
                        probabilities[summaryItem.Key] *= prob;
                    }

                   
                }
            }
            return probabilities;
        }

        /// <summary>
        /// Calculates probability.
        /// </summary>
        /// <param name="item"> element where includes item average and stdev </param>
        /// <param name="element"> new test data element</param>
        /// <returns>probability </returns>
        private double CalculateProbability(SummaryListElement item, double element)
        { 
            var probability =
                (double)(1 / (Math.Sqrt(2 * Math.PI) * item.StandardDeviation))*
                Math.Exp(-(double)(Math.Pow(element - item.Average, 2) / (2 * Math.Pow(item.StandardDeviation, 2))));

            return probability;
        }

        /// <summary>
        /// Calculates every class atribute average and stdev 
        /// </summary>
        /// <param name="classDictionary"> Grouped elements by classes</param>
        /// <returns>classSummary</returns>
        private Dictionary<string, List<SummaryListElement>> GetClassSummary(Dictionary<string, List<CustomDataElement>> classDictionary)
        {
            Dictionary < string, List <SummaryListElement>> classSummary = new Dictionary<string, List<SummaryListElement>>();

            foreach (var classItem in classDictionary)
            {
                classSummary.Add(classItem.Key, new List<SummaryListElement>());
           
                for (int i = 0; i < classItem.Value[0].Elements.Count; i++)
                {
                    List<double> temp = new List<double>();

                    foreach (var item in classItem.Value)
                    {
                        for (int j = 0; j < item.Elements.Count; j++)
                        {
                            if (j == i)
                            {
                                temp.Add(item.Elements[i]);
                            }
                        }
                    }

                    var average = Average(temp);
                    var standartDeviation = StandartDeviation(temp, average);

                    var summaryListElement = new SummaryListElement() { Average  = average, StandardDeviation = standartDeviation};

                    classSummary[classItem.Key].Add(summaryListElement);
                }
            }

            return classSummary;
        }

        /// <summary>
        /// Groups elements by the classes
        /// </summary>
        /// <param name="data">file data</param>
        /// <returns>classDictionary</returns>
        private Dictionary<string, List<CustomDataElement>> SeparateData(List<CustomDataElement> data)
        {
            Dictionary<string, List<CustomDataElement>> classDictionary = new Dictionary<string, List<CustomDataElement>>();

            foreach (var item in data)
            {
                if (classDictionary.ContainsKey(item.Type))
                {
                    classDictionary[item.Type].Add(item);
                }
                else
                {
                    List<CustomDataElement> temp = new List<CustomDataElement> {item};

                    classDictionary.Add(item.Type, temp);   
                }
            }
            return classDictionary;
        }

        /// <summary>
        /// Calclautes average.
        /// </summary>
        /// <param name="data"> data</param>
        /// <returns> average </returns>
        public double Average(List<double> data )
        {
           return data.Average();
        }

        /// <summary>
        /// Calculates standart deviation.
        /// </summary>
        /// <param name="data"> data </param>
        /// <param name="average"> average</param>
        /// <returns>std - standart deviation</returns>
        public double StandartDeviation(List<double> data, double average)
        { 
            double sum = data.Select(t => (t - average) * (t - average)).Sum();
            double std = Math.Sqrt(sum / data.Count);

            return std;
        }
    }
}
