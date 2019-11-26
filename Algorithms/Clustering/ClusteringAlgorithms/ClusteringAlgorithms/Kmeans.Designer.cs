using System.Windows.Forms;

namespace ClusteringAlgorithmsDataMining
{
    partial class Kmeans
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kmeans));
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SelectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.SetPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetClustersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeneratePointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateClustersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.InfoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl1.AutoSize = true;
            this.zedGraphControl1.Location = new System.Drawing.Point(13, 37);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(749, 466);
            this.zedGraphControl1.TabIndex = 9;
            this.zedGraphControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartPoint_MouseClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileToolStripButton,
            this.SelectToolStripButton,
            this.toolStripDropDownButton1,
            this.CalculateToolStripButton,
            this.InfoToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(774, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenFileToolStripButton
            // 
            this.OpenFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenFileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileToolStripButton.Image")));
            this.OpenFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFileToolStripButton.Name = "OpenFileToolStripButton";
            this.OpenFileToolStripButton.Size = new System.Drawing.Size(40, 22);
            this.OpenFileToolStripButton.Text = "Open";
            this.OpenFileToolStripButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // SelectToolStripButton
            // 
            this.SelectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SelectToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SelectToolStripButton.Image")));
            this.SelectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectToolStripButton.Name = "SelectToolStripButton";
            this.SelectToolStripButton.Size = new System.Drawing.Size(42, 22);
            this.SelectToolStripButton.Text = "Select";
            this.SelectToolStripButton.Click += new System.EventHandler(this.SelectToolStripButton_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetPointsToolStripMenuItem,
            this.SetClustersToolStripMenuItem,
            this.RemoveDataToolStripMenuItem,
            this.GeneratePointsToolStripMenuItem,
            this.GenerateClustersToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(53, 22);
            this.toolStripDropDownButton1.Text = "Points";
            // 
            // SetPointsToolStripMenuItem
            // 
            this.SetPointsToolStripMenuItem.Name = "SetPointsToolStripMenuItem";
            this.SetPointsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.SetPointsToolStripMenuItem.Text = "Set points";
            this.SetPointsToolStripMenuItem.Click += new System.EventHandler(this.SetPointsToolStripMenuItem_Click);
            // 
            // SetClustersToolStripMenuItem
            // 
            this.SetClustersToolStripMenuItem.Name = "SetClustersToolStripMenuItem";
            this.SetClustersToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.SetClustersToolStripMenuItem.Text = "Set clusters";
            this.SetClustersToolStripMenuItem.Click += new System.EventHandler(this.SetClustersToolStripMenuItem_Click);
            // 
            // RemoveDataToolStripMenuItem
            // 
            this.RemoveDataToolStripMenuItem.Name = "RemoveDataToolStripMenuItem";
            this.RemoveDataToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.RemoveDataToolStripMenuItem.Text = "Remove all data";
            this.RemoveDataToolStripMenuItem.Click += new System.EventHandler(this.RemoveDataToolStripMenuItem_Click);
            // 
            // GeneratePointsToolStripMenuItem
            // 
            this.GeneratePointsToolStripMenuItem.Name = "GeneratePointsToolStripMenuItem";
            this.GeneratePointsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.GeneratePointsToolStripMenuItem.Text = "Generate points";
            this.GeneratePointsToolStripMenuItem.Click += new System.EventHandler(this.GeneratePointsToolStripMenuItem_Click);
            // 
            // GenerateClustersToolStripMenuItem
            // 
            this.GenerateClustersToolStripMenuItem.Name = "GenerateClustersToolStripMenuItem";
            this.GenerateClustersToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.GenerateClustersToolStripMenuItem.Text = "Generate clusters";
            this.GenerateClustersToolStripMenuItem.Click += new System.EventHandler(this.GenerateClustersToolStripMenuItem_Click);
            // 
            // CalculateToolStripButton
            // 
            this.CalculateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CalculateToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CalculateToolStripButton.Image")));
            this.CalculateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalculateToolStripButton.Name = "CalculateToolStripButton";
            this.CalculateToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.CalculateToolStripButton.Text = "Calculate";
            this.CalculateToolStripButton.Click += new System.EventHandler(this.CalculateToolStripButton_Click);
            // 
            // InfoToolStripButton
            // 
            this.InfoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.InfoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("InfoToolStripButton.Image")));
            this.InfoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InfoToolStripButton.Name = "InfoToolStripButton";
            this.InfoToolStripButton.Size = new System.Drawing.Size(32, 22);
            this.InfoToolStripButton.Text = "Info";
            this.InfoToolStripButton.Click += new System.EventHandler(this.InfoToolStripButton_Click_1);
            // 
            // Kmeans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 515);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.zedGraphControl1);
            this.Name = "Kmeans";
            this.Text = "KMEANS";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private ToolStrip toolStrip1;
        private ToolStripButton OpenFileToolStripButton;
        private ToolStripButton CalculateToolStripButton;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem SetPointsToolStripMenuItem;
        private ToolStripMenuItem SetClustersToolStripMenuItem;
        private ToolStripMenuItem RemoveDataToolStripMenuItem;
        private ToolStripButton SelectToolStripButton;
        private ToolStripMenuItem GeneratePointsToolStripMenuItem;
        private ToolStripMenuItem GenerateClustersToolStripMenuItem;
        private ToolStripButton InfoToolStripButton;
    }
}

