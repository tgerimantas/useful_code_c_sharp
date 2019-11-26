using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ClassificationAlgorithmsDataMining1
{
    public class Explorer
    {
        /// <summary>
        /// Creates new test object.
        /// </summary>
        /// <param name="data">data </param>
        public CustomDataElement CreateNewTestObject(string data)
        {
            var elements = Regex.Split(data, ",");

            List<double> testData = new List<double>();

            foreach (var element in elements)
            {
                testData.Add(double.Parse(element.ToString()));
            }

            return  new CustomDataElement { Elements = testData, Type = null };
        }
    }
}