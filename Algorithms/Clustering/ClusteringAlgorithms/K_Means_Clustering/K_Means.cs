using System;
using System.Collections.Generic;
using System.Linq;

namespace KMeansClustering
{
    public class KMeans
    {
       
        private readonly List<Point> _points;
        private readonly List<Cluster> _clusters;
      

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="points"> points</param>
        /// <param name="clusters">clusters </param>
        public KMeans(List<Point> points, List<Cluster> clusters  )
        {
            _points = points;
            _clusters = clusters;
        }

        /// <summary>
        /// Calculate clusters
        /// </summary>
        /// <returns>distance</returns>
        public double Cluster()
        {
            //Removes cluster points
            foreach (var cluster in _clusters)
            {
                cluster.Points.Clear();
            }

            //Return last cluster points
            List<Point> oldClusterPoints = _clusters.Select(t => new Point() {X = t.ClusterPoint.X, Y = t.ClusterPoint.Y}).ToList();

            //Assign points to cluster
            AssignCluster();

            CalculateNewClusterPointPosition();

            //Return current cluster points
            List<Point> currentClusterPoints = _clusters.Select(t => new Point() {X = t.ClusterPoint.X, Y = t.ClusterPoint.Y}).ToList();

            double distance = 0;
            for (int i = 0; i < _clusters.Count; i++) {
                distance = distance + CalculateDistance(oldClusterPoints[i], currentClusterPoints[i]);
            }

            return distance;
        }

        /// <summary>
        /// Calculates new cluster point positions.
        /// </summary>
        private void CalculateNewClusterPointPosition()
        {
            foreach (var cluster in _clusters) 
            {
                double sumX = 0;
                double sumY = 0;
                List<Point> clusterPoints = cluster.Points;

                if (clusterPoints != null)
                {
                    foreach (var cPoint in clusterPoints)
                    {
                        sumX += cPoint.X;
                        sumY += cPoint.Y;
                    }

                    Point clusterPoint = cluster.ClusterPoint;

                    if (clusterPoints.Count > 0)
                    {
                        clusterPoint.X = sumX / clusterPoints.Count;
                        clusterPoint.Y = sumY / clusterPoints.Count;
                    }
                }
            }
        }

        /// <summary>
        /// Sets points to cluster.
        /// </summary>
        private void AssignCluster()
        {
            const double max = double.MaxValue;
            var cluster = 0;

            foreach (var point in _points)
            {
                var min = max;
                for (var i = 0; i < _clusters.Count; i++)
                {
                    var c = _clusters[i];
                    var distance = CalculateDistance(point, c.ClusterPoint);
                    if (distance < min)
                    {
                        min = distance;
                        cluster = i;
                    }
                }
       
                if (_clusters[cluster].Points == null)
                {
                    _clusters[cluster].Points = new List<Point>();
                }

                _clusters[cluster].Points.Add(point);
            }
        }

        /// <summary>
        /// Calculate distance between point and cluster
        /// </summary>
        /// <param name="point"> selected point position</param>
        /// <param name="clusterPoint"> cluster point </param>
        /// <returns>distance</returns>
        public double CalculateDistance(Point point, Point clusterPoint)
        {
            return Math.Sqrt(Math.Pow((clusterPoint.Y - point.Y), 2) + Math.Pow((clusterPoint.X - point.X), 2));
        }

        /// <summary>
        /// Returns cluster points.
        /// </summary>
        /// <returns>clusters</returns>
        public List<Cluster> GetClusters()
        {
            return _clusters;
        }
    }
}