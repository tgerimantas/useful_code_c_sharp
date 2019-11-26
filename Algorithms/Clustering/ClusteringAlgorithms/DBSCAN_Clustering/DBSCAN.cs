using System;
using System.Collections.Generic;
using System.Linq;

namespace DBSCAN_Clustering
{
    public class Dbscan
    {
        
        private readonly double _minPoints;
        private readonly double _epsilon;
        private readonly List<Point> _points;
        private List<Point> _visitedPoints;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="minPoints"> min points in cluster</param>
        /// <param name="epsilon"> length between points </param>
        /// <param name="points"> data </param>
        public Dbscan(double minPoints, double epsilon, List<Point> points)
        {
            _minPoints = minPoints;
            _epsilon = epsilon;
            _points = points;

            _visitedPoints = new List<Point>();
        }

        /// <summary>
        /// Calculate clusters.
        /// </summary>
        /// <returns> clusters</returns>
        public void Calculate(out List<Point> leftPoints, out List<Cluster> clusters)
        {
            clusters = new List<Cluster>();

            foreach (var point in _points)
            {       
                if (point.State != Point.PointState.Visited)
                {
                    point.State = Point.PointState.Visited;

                    List<Point> neighborPoints = RegionQuery(point);

                    if (neighborPoints.Count >= _minPoints)
                    {
                        Cluster cluster = new Cluster {Id = clusters.Count()};
                        ExpandCluster(point, neighborPoints, cluster); 
                        clusters.Add(cluster);                     
                    }
                    else{
                        point.State = Point.PointState.Noise;
                    }
                }              
            }
            leftPoints = _points.Where(t => t.State == Point.PointState.Noise).ToList();
        }

        /// <summary>
        /// Expand clustres
        /// </summary>
        /// <param name="selectedPoint">point</param>
        /// <param name="neighborPoints"> neighbor points </param>
        /// <param name="clusterId">existing cluster id</param>
        private void ExpandCluster(Point selectedPoint, List<Point> neighborPoints, Cluster cluster)
        {
            cluster.Points.Add(selectedPoint);
            selectedPoint.ClusterId = cluster.Id;

            foreach (var point in neighborPoints.ToList())
            {            
                if (point.State != Point.PointState.Visited)
                {
                    point.State = Point.PointState.Visited;

                    List<Point> neighborPoints1 = RegionQuery(point);
                    if (neighborPoints1.Count >= _minPoints)
                    {
                        neighborPoints = neighborPoints.Union(neighborPoints1).ToList();
                    }
                }

                if (point.ClusterId == -1)
                {
                    cluster.Points.Add(point);
                    point.ClusterId = cluster.Id;
                }
            }
        }

       

        /// <summary>
        /// Return points near selected point using epsilon.
        /// </summary>
        /// <param name="selectedPoint"> selected point </param>
        /// <returns> points near selected point </returns>
        private List<Point> RegionQuery(Point selectedPoint)
        {
            List<Point> neighborPoints = new List<Point>();

            foreach (var point in _points)
            {
                if (CalculateDistance(point, selectedPoint) <= _epsilon)
                {
                    neighborPoints.Add(point);
                }
            }

            return neighborPoints;
        }

        /// <summary>
        /// Calculates distance between points.
        /// </summary>
        /// <param name="point"> point 1</param>
        /// <param name="point1"> point 2</param>
        /// <returns>distance</returns>
        public double CalculateDistance(Point point, Point point1)
        {
            return Math.Sqrt(Math.Pow((point1.Y - point.Y), 2) + Math.Pow((point1.X - point.X), 2));
        }

   
    }
}