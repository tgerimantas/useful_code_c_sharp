using System;
using System.Windows.Forms;

namespace ClusteringAlgorithmsDataMining
{

    public partial class PointDataGeneratorForm : Form
    {
        public PointGeneratorPassValueHandler PointGeneratorPassValue { get; internal set; }

        public delegate void PointGeneratorPassValueHandler(string minX, string maxX, string minY, string maxY, string pointSize);

        public PointDataGeneratorForm()
        {
            InitializeComponent();
        }

        private void SetRandomDataButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(minXTextBox.Text) &&
               !string.IsNullOrWhiteSpace(maxXTextBox.Text) &&
               !string.IsNullOrWhiteSpace(minYTextBox.Text) &&
               !string.IsNullOrWhiteSpace(maxYTextBox.Text) &&
               !string.IsNullOrWhiteSpace(pointsTextBox.Text) &&    
               double.Parse(minXTextBox.Text) < double.Parse(maxXTextBox.Text)&&
               double.Parse(minYTextBox.Text) < double.Parse(maxYTextBox.Text)
               )
            {

                PointGeneratorPassValue(minXTextBox.Text, maxXTextBox.Text, minYTextBox.Text, maxYTextBox.Text, pointsTextBox.Text);

                this.Close();
            }
            else
            {
                MessageBox.Show(@"Please enter valid data");
            }
        }
    }
}
