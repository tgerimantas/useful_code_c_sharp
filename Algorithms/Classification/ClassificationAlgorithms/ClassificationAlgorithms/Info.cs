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
    public partial class Info : Form
    {
        private string _data;

        public Info(string data)
        {
            InitializeComponent();

            formText.Text = data;
        }

     
    }
}
