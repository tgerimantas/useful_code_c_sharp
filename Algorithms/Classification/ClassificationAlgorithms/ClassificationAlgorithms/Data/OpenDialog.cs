using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClassificationAlgorithmsDataMining1
{
    public class OpenDialog
    {
        /// <summary>
        /// Get data from file
        /// </summary>
        public List<string> GetData()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = @"Please select file",
                Filter = @"CSV files |*.csv;"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;

                if (path == null) throw new ArgumentNullException(nameof(path));

                //Reads a file
                var data = Utility.ReadFile(path);

                //Checks if data set form is closed
                if (Application.OpenForms.OfType<DataSetForm>().Count() != 1)
                {
                    return data;
                }
            }

            return null;
        }
    }
}