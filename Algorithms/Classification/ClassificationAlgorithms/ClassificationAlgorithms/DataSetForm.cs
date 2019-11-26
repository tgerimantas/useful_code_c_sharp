using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClassificationAlgorithmsDataMining1
{
    //Regex parameter
    public class Parameter
    {
        public static string RegexSplitParam = "\t|,";
    }

    public partial class DataSetForm : Form
    {
  
        public DataSetForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets data to form and updates
        /// </summary>
        /// <param name="data">data</param>
        public void SetData(List<string> data)
        {
            //Header
            var columns = Regex.Split(data[0], Parameter.RegexSplitParam);

            List<DataGridViewColumn> dataGridViewColumn = new List<DataGridViewColumn>();

            foreach (var column in columns)
            {
                var col = new DataGridViewTextBoxColumn
                {
                    HeaderText = column,
                    Name = column
                };

                dataGridViewColumn.Add(col);
            }

            dataGridView.Columns.AddRange(dataGridViewColumn.ToArray());

            //All data
            for (int i = 1; i < data.Count; i++)
            {
                string[] elements = Regex.Split(data[i], Parameter.RegexSplitParam);

                dataGridView.Rows.Add(elements);
            }

        }

        /// <summary>
        /// Clears form data.
        /// </summary>
        public void ClearData()
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Refresh();
        }
    }
}
