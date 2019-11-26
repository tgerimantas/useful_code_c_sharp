using ClusteringAlgorithmsDataMining;
using NaiveBayes_A;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClassificationAlgorithmsDataMining1
{
    public partial class NaiveBayesForm : Form
    {

        private OpenDialog _openDialogForm = new OpenDialog();
        private Explorer _explorer = new Explorer();
        private NaiveBayes _nb = new NaiveBayes();
        private CustomDataElement _newTestObject;
        private List<string> _fileData;

        public NaiveBayesForm()
        {
            InitializeComponent();
           
        }

        //Opens file dialog
        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            _fileData = _openDialogForm.GetData();

            var dataSetForm = new DataSetForm();
            dataSetForm.SetData(_fileData);
            dataSetForm.Show();
        }

        //Calculation button
        private void CalculateToolStripButton_Click(object sender, EventArgs e)
        {
            var selectColumns = SelectTextBox.Text.Replace(" ", string.Empty).Split(',');

            var classColumn = ClassTextBox.Text.Replace(" ", string.Empty);

            if (selectColumns == null || selectColumns.Length == 0 || string.IsNullOrEmpty(classColumn))
            {
                MessageBox.Show(@"Error. Please add data");
            }
            else
            {
                ToConsole(@"Calculating");
         
                var answer = _nb.Calculate(_newTestObject,  _fileData, selectColumns, classColumn);

                ToConsole(@"Answer -> " + answer);
            }
        }

        //New test object button
        private void NewTestObjectButton_Click(object sender, EventArgs e)
        {
            var data = NewObjectTextBox.Text.ToString().Replace(" ", string.Empty);

            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show(@"Please add data");
            }
            else
            {
                _newTestObject = _explorer.CreateNewTestObject(data);

                ToConsole(@"Created new test");
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
            string data = ClassificationAlgorithms.Properties.Resources.InfoNaiveBayes;

            Info form = new Info(data);

            form.Show();
        }
    }
}
