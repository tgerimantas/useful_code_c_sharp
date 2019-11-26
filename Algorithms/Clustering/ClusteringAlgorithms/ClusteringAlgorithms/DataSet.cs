using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClusteringAlgorithmsDataMining
{
    public partial class DataSet : Form
    {

        public SelectColumnPassValueHandler SelectColumnPassValuePassValue { get; internal set; }

        public delegate void SelectColumnPassValueHandler(int xColumn, int yColumn);

        public DataSet()
        {        
            InitializeComponent();
        }

        public void SetData(List<string> data)
        {

            var columns = Regex.Split(data[0], "\t|,");

            List<DataGridViewColumn> dataGridViewColumn = new List<DataGridViewColumn>();

            foreach (var column in columns)
            {
                var col = new DataGridViewTextBoxColumn();
                col.HeaderText = column;
                col.Name = column;

                dataGridViewColumn.Add(col);
            }

            dataGridView.Columns.AddRange(dataGridViewColumn.ToArray());

            for (int i = 1; i < data.Count; i++)
            {
                string[] elements = Regex.Split(data[i], "\t|,");

                dataGridView.Rows.Add(elements);
            }
            
        }


        private void SelectColumnsButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(xColumnTextBox.Text) &&
                !string.IsNullOrWhiteSpace(yColumnTextBox.Text))
            {
                SelectColumnPassValuePassValue(int.Parse(xColumnTextBox.Text)-1, int.Parse(yColumnTextBox.Text)-1);
            }
            else
            {
                MessageBox.Show(@"Please enter valid data");
            }
        }

        public void ClearData()
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Refresh();
        }
    }
}
