using System.Collections.Generic;
using System.Drawing;


namespace KMeansClustering
{
    public class Cluster
    {
        public Point ClusterPoint { get; set; }

        public List<Point> Points { get; set; }

        public int Id { get; set; }

        public Color Color { get; set;}  
    }
}