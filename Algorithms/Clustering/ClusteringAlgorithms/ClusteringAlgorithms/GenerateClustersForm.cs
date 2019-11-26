using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Point = KMeansClustering.Point;

namespace ClusteringAlgorithmsDataMining
{
    public partial class GenerateClustersForm : Form
    {
        private readonly List<Point> _points;

        public KmeanClusterGeneratorValueHandler KMeanClusterGeneratorPassValue { get; internal set; }

        public delegate void KmeanClusterGeneratorValueHandler(string clusterSize);

        public GenerateClustersForm(List<Point> points )
        {
            _points = points;
            InitializeComponent();
        }

        private void SetRandomDataButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(clustersTextBox.Text) && _points.Count > 0)
            {
                KMeanClusterGeneratorPassValue(clustersTextBox.Text);

                Close();
            }
            else
            {
                MessageBox.Show(@"Please set points first or enter cluster size");
            }
        }
    }
}
