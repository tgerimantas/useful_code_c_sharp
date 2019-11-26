using System;
using System.Collections.Generic;
using System.Drawing;

namespace KMeansClustering
{
    public class Generate
    {
      
        private static readonly object SyncLock = new object();
        private static readonly Random Random = new Random();

        /// <summary>
        /// Generates random points
        /// </summary>
        /// <returns>points </returns>
        public List<Point> InitializeRandomPoints(int pointSize, double minX, double maxX, double minY, double maxY)
        {
            List<Point> points = new List<Point>();

            for (int i = 0; i < pointSize; i++)
            {
                points.Add(InitializePoint(minX, maxX, minY, maxY));
            }

            return points;
        }

        /// <summary>
        /// Generates random cluster points
        /// </summary>
        /// <returns>clusters</returns>
        public List<Cluster> InitializeRandomClusters(int clusterSize, double minX, double maxX, double minY, double maxY)
        {
            List<Cluster> clusters = new List<Cluster>();

            for (int i = 0; i < clusterSize; i++)
            {
                var point = InitializePoint(minX, maxX, minY, maxY);

                var cluster = new Cluster()
                {
                    Id = i,
                    ClusterPoint = point,
                    Points = new List<Point>(),
                    Color = Color.FromArgb(Random.Next(256), Random.Next(256), Random.Next(256))
                };

                clusters.Add(cluster);
            }

            return clusters;
        }

        /// <summary>
        /// Generates random point.
        /// </summary>
        /// <returns>point</returns>
        private Point InitializePoint(double minX, double maxX, double minY, double maxY)
        {
            Point point = null;

            lock (SyncLock)
            {
                point = new Point()
                {
                    X = minX + (maxX - minX) * Random.NextDouble(),
                    Y = minY + (maxY - minY) * Random.NextDouble()
                };
            }

            return point;
        }
    }
}