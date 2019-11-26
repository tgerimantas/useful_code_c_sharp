using ClassificationAlgorithms.DataSetup;
using ClassificationAlgorithms.Models;
using ClassificationAlgorithmsDataMining1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KNN_A
{
    public class Knn
    {
        public Knn()
        {

        }

        public object Calculate(CustomDataElement testDataObject, int k, List<string> fileData, string[] selectColumns, string classColumn)
        {
            var data = DataSetup.SetUpData(fileData, selectColumns, classColumn);

            var neighbors = GetNeighbors(data, testDataObject, k);

            var type = SelectType(neighbors);

            return type;
        }

        /// <summary>
        /// Returns reighbor list using selected test data.
        /// </summary>
        /// <returns> neighbor list </returns>
        private List<Distances> GetNeighbors(List<CustomDataElement> data, CustomDataElement testDataObject, int k)
        {
            List<Distances> distances = new List<Distances>();
            List<Distances> neighbors = new List<Distances>();

            foreach (var obj in data)
            {
                var distance = CalculateDistance(testDataObject, obj.Elements);
                distances.Add(new Distances() { Data = obj, Distance = distance });
            }

            List<Distances> sortedDistances = distances.OrderBy(t => t.Distance).ToList();

            for (int i = 0; i < k; i++)
            {
                neighbors.Add(sortedDistances[i]);
            }

            return neighbors;
        }

        /// <summary>
        /// Selects optimal type of input object.
        /// </summary>
        /// <param name="neighbors"> neighbors list </param>
        /// <returns> type of input data</returns>
        private String SelectType(List<Distances> neighbors)
        {
            String minDistanceNeighborType = null;

            var query =
                 from word in neighbors
                 group word by word.Data.Type into g
                 select new { g.Key, Count = g.Count() };

            var allSame = query.All(x => x.Count == query.First().Count);

            if (allSame == true)
            {
                var firstElement = neighbors.OrderBy(t => t.Distance).FirstOrDefault();
                if (firstElement != null)
                    minDistanceNeighborType = firstElement.Data.Type;
            }
            else
            {
                minDistanceNeighborType = query.OrderByDescending(t => t.Count).FirstOrDefault().Key;
            }

            return minDistanceNeighborType;
        }

        /// <summary>
        /// Calculates distance between points using Euclide algorithm.
        /// </summary>
        /// <param name="columnElements"> points</param>
        /// <param name="testDataObject"> testing object</param>
        /// <returns> distance between elements</returns>
        private double CalculateDistance(CustomDataElement testDataObject, List<double> columnElements)
        {
            var distance = 0.0;

            for (int i = 0; i < testDataObject.Elements.Count; i++)
            {
                distance += Math.Pow((columnElements[i] - testDataObject.Elements[i]), 2);
            }

            return Math.Sqrt(distance);
        }    
    }
}
 
