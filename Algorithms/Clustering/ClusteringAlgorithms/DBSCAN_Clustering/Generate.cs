using System;
using System.Collections.Generic;

namespace DBSCAN_Clustering
{
    public class Generate
    {

        private static readonly object SyncLock = new object();
        private static readonly Random Random = new Random();

        public List<Point> InitializeRandomPoints(int pointSize, double minX, double maxX, double minY, double maxY)
        {
            List<Point> points = new List<Point>();

            for (int i = 0; i < pointSize; i++)
            {
                points.Add(InitializePoint(minX, maxX, minY, maxY));
            }

            return points;
        }

        private Point InitializePoint(double minX, double maxX, double minY, double maxY)
        {
            Point point = null;

            //For element to get ramdom
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