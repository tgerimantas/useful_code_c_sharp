namespace DBSCAN_Clustering
{

    public class Point
    {

        public enum PointState
        {
            Noise,
            Visited
        }

        public double X { get; set; }
        public double Y { get; set; }
        public PointState State { get; set; }
        public int ClusterId { get; set; }

        public Point()
        {
            ClusterId = -1;
        }
    }
}