using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using KMeansClustering;
using ZedGraph;
using Cluster = KMeansClustering.Cluster;
using Generate = KMeansClustering.Generate;
using Point = KMeansClustering.Point;

namespace ClusteringAlgorithmsDataMining
{
    public partial class Kmeans : Form
    {
        private readonly Color _baseColor = Color.Black;
        private MenuEnum _selectedEnum = MenuEnum.None;
      
        public List<Point> Points { get; set; }
        public List<Cluster> Clusters { get; set; }
        private DataSet _dataSetForm;
        private List<string> _dataFromFile = new List<string>();


        enum MenuEnum
        {
            None,
            Points,
            Clusters
        }

        public Kmeans()
        {
            InitializeComponent();

            Points = new List<Point>();
            Clusters = new List<Cluster>();
            _dataSetForm = new DataSet();

            GraphPane pane = zedGraphControl1.GraphPane;
            pane.Title.Text = @"KMEANS";

            if (Points.Count == 0)
            {
                GenerateClustersToolStripMenuItem.Enabled = false;
            }
        }


        private void SetGraphData()
        {
            var points = Points;

            var clusters = Clusters;

            GraphPane pane = zedGraphControl1.GraphPane;

            zedGraphControl1.GraphPane.CurveList.Clear();

            zedGraphControl1.Invoke(new Action(() => zedGraphControl1.Refresh()));

            //Set up points
            PointPairList pointPairList = new PointPairList();

            foreach (var point in points)
            {
                pointPairList.Add(point.X, point.Y);
            }

            LineItem pointLineItem = new LineItem(null, pointPairList, _baseColor, SymbolType.Default, 3.0f)
            {
                Line = {IsVisible = false}
            };


            pointLineItem.Symbol.Fill.Type = FillType.Solid;

            pane.CurveList.Add(pointLineItem);

            //Set up cluster points
            foreach (var cluster in clusters)
            {
                PointPairList clusterPointPairList = new PointPairList
                {
                    {cluster.ClusterPoint.X, cluster.ClusterPoint.Y}
                };

                LineItem clusterLineItem = new LineItem(null, clusterPointPairList, cluster.Color, SymbolType.Circle,3.0f)
                {
                    Line = {IsVisible = false}
                };

                clusterLineItem.Symbol.Fill.Type = FillType.Solid;

                pane.CurveList.Add(clusterLineItem);
            }

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Invoke(new Action(() => zedGraphControl1.Update()));
        }

        private void UpdateGraphData(List<Cluster> clusters )
        {
            
            GraphPane pane = zedGraphControl1.GraphPane;

            zedGraphControl1.GraphPane.CurveList.Clear();

            zedGraphControl1.Invoke(new Action(() => zedGraphControl1.Refresh()));

            foreach (var cluster in clusters)
            {
                PointPairList elementPairList = new PointPairList();
                PointPairList clusterPairList = new PointPairList();

                if (cluster.Points != null)
                {
                    foreach (var point in cluster.Points)
                    {
                        elementPairList.Add(point.X, point.Y);
                    }

                    LineItem pointLineItem = new LineItem(null, elementPairList, cluster.Color, SymbolType.Default, 3.0f)
                    {
                        Line = {IsVisible = false}
                    };


                    pointLineItem.Symbol.Fill.Type = FillType.Solid;
                    pane.CurveList.Add(pointLineItem);
                }

                clusterPairList.Add(cluster.ClusterPoint.X, cluster.ClusterPoint.Y);

                LineItem clusterLineItem = new LineItem(null, clusterPairList, cluster.Color, SymbolType.Circle, 3.0f)
                {
                    Line = {IsVisible = false}
                };


                clusterLineItem.Symbol.Fill.Type = FillType.Solid;
                pane.CurveList.Add(clusterLineItem);
            }

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Invoke(new Action(() => zedGraphControl1.Update()));
        }

        private void CalculateToolStripButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Calculations);
            thread.Start();       
        }

        private void Calculations()
        {
            if (Clusters.Count == 0 && Points.Count == 0)
            {
                MessageBox.Show(@"Please add data");
            }
            else
            {
                Calculate();                
            }

        }

        private void Calculate()
        {
            KMeans kMeans = new KMeans(Points, Clusters);

            var finish = true;

            while (finish)
            {
                var distance = kMeans.Cluster();

                var clusters = kMeans.GetClusters();

                Thread.Sleep(2000);

                UpdateGraphData(clusters);

                if (distance == 0)
                {
                    finish = false;
                }
            }

            MessageBox.Show(@"Done");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = @"Please select file",
                Filter = @"CSV files |*.csv;"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ClearDatasetFormData();

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

        private void ClearDatasetFormData()
        {
            _dataFromFile.Clear();
            _dataSetForm.ClearData();
        }

        private void SelectColumnData(int xcolumn, int ycolumn)
        {
            ClearPointsData();

            for (int i = 1; i < _dataFromFile.Count; i++)
            {
                string[] elements = Regex.Split(_dataFromFile[i], "\t|,");

                Points.Add(new Point() {X= double.Parse(elements[xcolumn]), Y=double.Parse(elements[ycolumn]) });
            }

            SetGraphData();

            if (Points.Count > 0)
            {
                GenerateClustersToolStripMenuItem.Enabled = true;
            }
        }

        private void RemoveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPointsData();  
        }

        private void ClearPointsData()
        {
            Points.Clear();
            Clusters.Clear();

            if (Points.Count == 0)
            {
                GenerateClustersToolStripMenuItem.Enabled = false;
            }
          
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.Refresh();
        }


        private void SetPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedEnum = MenuEnum.Points;
        }

        private void SetClustersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedEnum = MenuEnum.Clusters;
        }

        private void SelectToolStripButton_Click(object sender, EventArgs e)
        {
            _selectedEnum = MenuEnum.None;
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

                switch (_selectedEnum)
                {
                    case MenuEnum.Points:
                    {
                        Points.Add(new Point() {X = x, Y = y });

                        //Set up points
                        PointPairList pointPairList = new PointPairList();

                        pointPairList.Add(x, y);

                        pointLineItem = new LineItem(null, pointPairList, _baseColor, SymbolType.Default, 3.0f);
                    }
                        break;

                    case MenuEnum.Clusters:
                    {
                        Random random = new Random();

                        var point = new Point() { X = x, Y = y };

                        var cluster = new Cluster()
                        {
                            Id = Clusters.Count,
                            ClusterPoint = point,
                            Points = new List<Point>(),
                            Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256))
                        };

                        Clusters.Add(cluster);

                        //Set up points
                        PointPairList pointPairList = new PointPairList();

                        pointPairList.Add(x, y);

                        pointLineItem = new LineItem(null, pointPairList, cluster.Color, SymbolType.Circle, 3.0f);
                    }
                        break;
                    case MenuEnum.None:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                if (pointLineItem != null)
                {
                    pointLineItem.Line.IsVisible = false;
                    pointLineItem.Symbol.Fill.Type = FillType.Solid;

                    pane.CurveList.Add(pointLineItem);

                    zedGraphControl1.Refresh();
                }

            }

            if (Points.Count > 0)
            {
                GenerateClustersToolStripMenuItem.Enabled = true;
            }
        }

        private void GeneratePointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PointDataGeneratorForm form = new PointDataGeneratorForm();
            form.PointGeneratorPassValue += RandomPointDataGenerator;
            form.Show();
        }

        private void RandomPointDataGenerator(string minX, string maxX, string minY, string maxY, string pointSize)
        {
            Generate generate = new Generate();

            //Init random points coordinates
            Points = generate.InitializeRandomPoints(int.Parse(pointSize), double.Parse(minX), double.Parse(maxX), double.Parse(minY), double.Parse(maxY));

            ShowPoints();

            if (Points.Count > 0)
            {
                GenerateClustersToolStripMenuItem.Enabled = true;
            }
        }

        private void ShowPoints()
        {
            var points = Points;

            GraphPane pane = zedGraphControl1.GraphPane;

            zedGraphControl1.Invoke(new Action(() => zedGraphControl1.Refresh()));

            //Set up points
            PointPairList pointPairList = new PointPairList();

            foreach (var point in points)
            {
                pointPairList.Add(point.X, point.Y);
            }

            LineItem pointLineItem = new LineItem(null, pointPairList, _baseColor, SymbolType.Default, 3.0f)
            {
                Line = {IsVisible = false}
            };


            pointLineItem.Symbol.Fill.Type = FillType.Solid;

            pane.CurveList.Add(pointLineItem);

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Invoke(new Action(() => zedGraphControl1.Update()));
        }

        private void GenerateClustersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateClustersForm form = new GenerateClustersForm(Points);
            form.KMeanClusterGeneratorPassValue += RandomClusterDataGenerator;
            form.Show();
        }

        private void RandomClusterDataGenerator(string clustersize)
        {
            Generate generate = new Generate();

            //Init random points coordinates

            var maxX = Double.MinValue;
            var maxY = Double.MinValue;
            var minX = Double.MaxValue;
            var minY = Double.MaxValue;

            var points = Points;

            foreach (var point in points)
            {             
                if (maxX < point.X) {maxX = point.X;}

                if (maxY < point.Y){maxY = point.Y;}

                if (minX > point.X){minX = point.X;}

                if (minY > point.Y){minY = point.Y;}
            }
    
            Clusters = generate.InitializeRandomClusters(int.Parse(clustersize), minX, maxX, minY, maxY);

            ShowClusters();          
        }

        private void ShowClusters()
        {
            var clusters = Clusters;

            GraphPane pane = zedGraphControl1.GraphPane;

            //zedGraphControl1.GraphPane.CurveList.Clear();

            zedGraphControl1.Invoke(new Action(() => zedGraphControl1.Refresh()));

            //Set up cluster points
            foreach (var cluster in clusters)
            {
                PointPairList clusterPointPairList = new PointPairList
                {
                    {cluster.ClusterPoint.X, cluster.ClusterPoint.Y}
                };


                LineItem clusterLineItem = new LineItem(null, clusterPointPairList, cluster.Color, SymbolType.Circle,3.0f)
                {
                    Line = {IsVisible = false}
                };


                clusterLineItem.Symbol.Fill.Type = FillType.Solid;

                pane.CurveList.Add(clusterLineItem);
            }

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Invoke(new Action(() => zedGraphControl1.Update()));
        }

        private void InfoToolStripButton_Click_1(object sender, EventArgs e)
        {
            string data = Properties.Resources.InfoKmeans;

            Info form = new Info(data);
            form.Show();
        }
    }
}
