using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassificationAlgorithmsDataMining1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Opens KNN form
        private void KnearButton_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.Show();
        }

        //Opens NaivesBayes form
        private void button2_Click(object sender, EventArgs e)
        {
            var form = new NaiveBayesForm();
            form.Show();
        }
    }
}
