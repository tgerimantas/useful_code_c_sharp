using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DBSCAN_Clustering
{
    public class Cluster
    {
        public int Id { get; set; }
        public List<Point> Points { get; set; }

        public Cluster()
        {
            Points = new List<Point>();
        }
    }
}
