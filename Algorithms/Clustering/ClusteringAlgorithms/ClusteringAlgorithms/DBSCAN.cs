using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ZedGraph;
using DBSCAN_Clustering;
using Point = DBSCAN_Clustering.Point;
using System.IO;

namespace ClusteringAlgorithmsDataMining
{
    public partial class DBSCAN : Form
    {
     
        private readonly Color _baseColor = Color.Black;
        private MenuEnum _selectedEnum = MenuEnum.None;
        private DataSet _dataSetForm;
        private List<string> _dataFromFile = new List<string>();
        private List<Point> Points { get; set; }

        public DBSCAN()
        {
            InitializeComponent();
           
            Points = new List<Point>();
            _dataSetForm = new DataSet();

            GraphPane pane = zedGraphControl1.GraphPane;
            pane.Title.Text = @"DBSCAN";
        }

        enum MenuEnum
        {
            None,
            Points
        }


        private void SetGraphData()
        {
            var points = Points;

            GraphPane pane = zedGraphControl1.GraphPane;

            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.Refresh();

            //Set up points
            PointPairList pointPairList = new PointPairList();

            foreach (var point in points)
            {
                pointPairList.Add(point.X, point.Y);
            }

            LineItem pointLineItem = new LineItem(null, pointPairList, _baseColor, SymbolType.Default, 3.0f);
            pointLineItem.Line.IsVisible = false;
            pointLineItem.Symbol.Fill.Type = FillType.Solid;

            pane.CurveList.Add(pointLineItem);

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Update();
        }

        private void CalculateToolStripButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(minPointsTextBox.Text) &&
                !string.IsNullOrWhiteSpace(epsilonTextBox.Text) &&
                double.Parse(minPointsTextBox.Text) <= Points.Count )
            {
               Calculations();
            }
            else
            {
                MessageBox.Show(@"Please enter valid data");
            }
        }

        private void Calculations()
        {
            List<Point> leftPoints;
            List<Cluster> clusters;
           
            Dbscan dbscan = new Dbscan(double.Parse(minPointsTextBox.Text), double.Parse(epsilonTextBox.Text), Points);

            dbscan.Calculate(out leftPoints, out clusters);

            UpdateGraphData(clusters, leftPoints);

            MessageBox.Show(@"Done");
        }


        private void UpdateGraphData(List<Cluster> clusters, List<Point> points)
        {
            Random random = new Random();

            GraphPane pane = zedGraphControl1.GraphPane;

            zedGraphControl1.GraphPane.GraphObjList.Clear();
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.Invoke(new Action(() => zedGraphControl1.Refresh()));

            foreach (var cluster in clusters)
            {
                PointPairList element = new PointPairList();

                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                if (cluster.Points != null)
                {
                    foreach (var point in cluster.Points)
                    {
                        element.Add(point.X, point.Y);
                    }

                    LineItem clusterPointLineItem = new LineItem(null, element, color, SymbolType.Default, 3.0f);

                    clusterPointLineItem.Line.IsVisible = false;
                    clusterPointLineItem.Symbol.Fill.Type = FillType.Solid;

                    pane.CurveList.Add(clusterPointLineItem);
                }
            }


            //Set up points
            PointPairList pointPairList = new PointPairList();

            foreach (var point in points)
            {
                pointPairList.Add(point.X, point.Y);
            }

            LineItem pointLineItem = new LineItem(null, pointPairList, _baseColor, SymbolType.Default, 3.0f);
            pointLineItem.Line.IsVisible = false;
            pointLineItem.Symbol.Fill.Type = FillType.Solid;

            pane.CurveList.Add(pointLineItem);

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Invoke(new Action(() => zedGraphControl1.Update()));
        }

        private void GenerateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PointDataGeneratorForm form = new PointDataGeneratorForm();
            form.PointGeneratorPassValue += RandomDataGeneratorForm_PassValue;
            form.Show();
        }

        private void RandomDataGeneratorForm_PassValue(string minX, string maxX, string minY, string maxY, string pointSize)
        {           
            Generate generate = new Generate();

            //Init random points coordinates
            Points = generate.InitializeRandomPoints(int.Parse(pointSize), double.Parse(minX), double.Parse(maxX), double.Parse(minY), double.Parse(maxY));

            SetGraphData();
        }

        private void SetPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedEnum = MenuEnum.Points;
        }

        private void RemovePointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPointsData();

            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.Refresh();
        }

        private void ClearDataSetFormData()
        {
            _dataFromFile.Clear();
            _dataSetForm.ClearData();
        }

        private void ClearPointsData()
        {
            Points.Clear();
        }

        private void SelectToolStripButton_Click(object sender, EventArgs e)
        {
            _selectedEnum = MenuEnum.None;
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = @"Please select file",
                Filter = @"CSV files |*.csv;"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ClearDataSetFormData();

                string path = openFileDialog.FileName;

                if (path == null) throw new ArgumentNullException(nameof(path));

                var data = FileIo.ReadFile(path);

                _dataFromFile = data;

                if (Application.OpenForms.OfType<DataSet>().Count() == 1)
                {

                }
                else
                {
                    _dataSetForm = new DataSet();
                }

                _dataSetForm.SetData(data);
                _dataSetForm.SelectColumnPassValuePassValue = SelectColumnData;
                _dataSetForm.Show();
            }
        }

        private void SelectColumnData(int xcolumn, int ycolumn)
        {
            ClearPointsData();

            for (int i = 1; i < _dataFromFile.Count; i++)
            {
                string[] elements = Regex.Split(_dataFromFile[i], "\t|,");

                Points.Add(new Point()
                {
                    X = double.Parse(elements[xcolumn]),
                    Y = double.Parse(elements[ycolumn])
                });
            }

            SetGraphData();
        }


        private void chartPoint_MouseClick(object sender, MouseEventArgs e)
        {
            GraphPane pane = zedGraphControl1.GraphPane;

            double x;
            double y;

            pane.Legend.IsVisible = false;

            pane.ReverseTransform(e.Location, out x, out y);

            if (x != null && y != null)
            {
                LineItem pointLineItem = null;

                if (_selectedEnum == MenuEnum.Points)
                {
                    Points.Add(new Point()
                    {
                        X = x,
                        Y = y
                    });

                    //Set up points
                    PointPairList pointPairList = new PointPairList();
                    pointPairList.Add(x, y);

                    pointLineItem = new LineItem(null, pointPairList, _baseColor, SymbolType.Default, 3.0f);
                }
                

                if (pointLineItem != null)
                {
                    pointLineItem.Line.IsVisible = false;
                    pointLineItem.Symbol.Fill.Type = FillType.Solid;

                    pane.CurveList.Add(pointLineItem);

                    zedGraphControl1.Refresh();
                }

            }
        }

        private void InfoToolStripButton_Click_1(object sender, EventArgs e)
        {
            string data = Properties.Resources.InfoDBSCAN;

            Info form = new Info(data);

            form.Show();
        }
    }
}
