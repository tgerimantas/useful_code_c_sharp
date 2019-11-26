using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClusteringAlgorithmsDataMining;
using KNN_A;

namespace ClassificationAlgorithmsDataMining1
{
    public partial class Form1 : Form
    {
        private OpenDialog openDialogForm = new OpenDialog();
        private Explorer explorer = new Explorer();
        private CustomDataElement _newTestObject;
        private List<string> _fileData;

        public Form1()
        {
            InitializeComponent();
        }

        //Select file button
        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            _fileData = openDialogForm.GetData();

            var dataSetForm = new DataSetForm();
            dataSetForm.SetData(_fileData);
            dataSetForm.Show();
        }

        //New object
        private void newObjectButton_Click(object sender, EventArgs e)
        {
            var data = NewObjectTextBox.Text.ToString().Replace(" ", string.Empty);

            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show(@"Please add data");
            }
            else
            {
               _newTestObject = explorer.CreateNewTestObject(data);

               ToConsole(@"Created new test");
            }
        }

        //Calculate button
        private void CalculateToolStripButton_Click(object sender, EventArgs e)
        {
            var selectColumns = SelectTextBox.Text.Replace(" ", string.Empty).Split(',');

            var classColumn = ClassTextBox.Text.Replace(" ", string.Empty);

            var kElement = KtextBox.Text.ToString().Replace(" ", string.Empty);

            if (string.IsNullOrEmpty(classColumn) || selectColumns == null || selectColumns.Length == 0 
                || string.IsNullOrEmpty(kElement) || _newTestObject == null)
            {
                MessageBox.Show(@"Please add data");
            }
            else
            {
                ToConsole(@"Calculating");

                var knn = new Knn();
                var answer = knn.Calculate(_newTestObject, int.Parse(kElement), _fileData, selectColumns, classColumn);

                ToConsole(@"Answer -> " + answer);
            }
        }


        /// <summary>
        /// Writes text to form console.
        /// </summary>
        /// <param name="text"></param>
        private void ToConsole(string text)
        {
            ConsoleTextBox.Text += text + Environment.NewLine;
        }

        private void InfoToolStripButton_Click(object sender, EventArgs e)
        {
            string data = ClassificationAlgorithms.Properties.Resources.InfoKNN;

            Info form = new Info(data);
            form.Show();
        }
    }

    
}
