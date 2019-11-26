namespace ClusteringAlgorithmsDataMining
{
    partial class DBSCAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBSCAN));
            this.label2 = new System.Windows.Forms.Label();
            this.minPointsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.epsilonTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SelectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PointsToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.GenerateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemovePointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.InfoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Min points";
            // 
            // minPointsTextBox
            // 
            this.minPointsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minPointsTextBox.Location = new System.Drawing.Point(73, 356);
            this.minPointsTextBox.Name = "minPointsTextBox";
            this.minPointsTextBox.Size = new System.Drawing.Size(39, 20);
            this.minPointsTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Epsilon";
            // 
            // epsilonTextBox
            // 
            this.epsilonTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.epsilonTextBox.Location = new System.Drawing.Point(176, 356);
            this.epsilonTextBox.Name = "epsilonTextBox";
            this.epsilonTextBox.Size = new System.Drawing.Size(39, 20);
            this.epsilonTextBox.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripButton,
            this.SelectToolStripButton,
            this.PointsToolStripDropDownButton,
            this.CalculateToolStripButton,
            this.InfoToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(697, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenToolStripButton
            // 
            this.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripButton.Image")));
            this.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripButton.Name = "OpenToolStripButton";
            this.OpenToolStripButton.Size = new System.Drawing.Size(40, 22);
            this.OpenToolStripButton.Text = "Open";
            this.OpenToolStripButton.Click += new System.EventHandler(this.OpenToolStripButton_Click);
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
            // PointsToolStripDropDownButton
            // 
            this.PointsToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PointsToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateToolStripMenuItem,
            this.SetPointsToolStripMenuItem,
            this.RemovePointsToolStripMenuItem});
            this.PointsToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("PointsToolStripDropDownButton.Image")));
            this.PointsToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PointsToolStripDropDownButton.Name = "PointsToolStripDropDownButton";
            this.PointsToolStripDropDownButton.Size = new System.Drawing.Size(53, 22);
            this.PointsToolStripDropDownButton.Text = "Points";
            // 
            // GenerateToolStripMenuItem
            // 
            this.GenerateToolStripMenuItem.Name = "GenerateToolStripMenuItem";
            this.GenerateToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.GenerateToolStripMenuItem.Text = "Generate random points";
            this.GenerateToolStripMenuItem.Click += new System.EventHandler(this.GenerateToolStripMenuItem_Click);
            // 
            // SetPointsToolStripMenuItem
            // 
            this.SetPointsToolStripMenuItem.Name = "SetPointsToolStripMenuItem";
            this.SetPointsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.SetPointsToolStripMenuItem.Text = "Set points";
            this.SetPointsToolStripMenuItem.Click += new System.EventHandler(this.SetPointsToolStripMenuItem_Click);
            // 
            // RemovePointsToolStripMenuItem
            // 
            this.RemovePointsToolStripMenuItem.Name = "RemovePointsToolStripMenuItem";
            this.RemovePointsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.RemovePointsToolStripMenuItem.Text = "Remove all points";
            this.RemovePointsToolStripMenuItem.Click += new System.EventHandler(this.RemovePointsToolStripMenuItem_Click);
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
            // zedGraphControl1
            // 
            this.zedGraphControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl1.AutoSize = true;
            this.zedGraphControl1.Location = new System.Drawing.Point(5, 26);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(680, 324);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartPoint_MouseClick);
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
            // DBSCAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 378);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.epsilonTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minPointsTextBox);
            this.Controls.Add(this.label2);
            this.Name = "DBSCAN";
            this.Text = "DBSCAN";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox minPointsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox epsilonTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenToolStripButton;
        private System.Windows.Forms.ToolStripButton SelectToolStripButton;
        private System.Windows.Forms.ToolStripButton CalculateToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton PointsToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem GenerateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemovePointsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.ToolStripButton InfoToolStripButton;
    }
}