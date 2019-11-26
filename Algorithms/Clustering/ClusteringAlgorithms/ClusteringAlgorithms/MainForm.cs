using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClusteringAlgorithmsDataMining
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //KMeans
        private void openKMeansButton_Click(object sender, EventArgs e)
        {
            var form = new Kmeans();
            form.Show();
        }

        //DBSCAN
        private void button2_Click(object sender, EventArgs e)
        {
            var form = new DBSCAN();
            form.Show();
        }
    }
}
