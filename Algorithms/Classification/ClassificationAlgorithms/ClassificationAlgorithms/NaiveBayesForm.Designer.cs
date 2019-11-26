namespace ClassificationAlgorithmsDataMining1
{
    partial class NaiveBayesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NaiveBayesForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CalculateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.NewObjectTextBox = new System.Windows.Forms.TextBox();
            this.NewTestObjectButton = new System.Windows.Forms.Button();
            this.ConsoleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClassTextBox = new System.Windows.Forms.TextBox();
            this.SelectTextBox = new System.Windows.Forms.TextBox();
            this.InfoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripButton,
            this.CalculateToolStripButton,
            this.InfoToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(554, 25);
            this.toolStrip1.TabIndex = 21;
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
            // NewObjectTextBox
            // 
            this.NewObjectTextBox.Location = new System.Drawing.Point(108, 111);
            this.NewObjectTextBox.Name = "NewObjectTextBox";
            this.NewObjectTextBox.Size = new System.Drawing.Size(446, 20);
            this.NewObjectTextBox.TabIndex = 30;
            // 
            // NewTestObjectButton
            // 
            this.NewTestObjectButton.Location = new System.Drawing.Point(12, 111);
            this.NewTestObjectButton.Name = "NewTestObjectButton";
            this.NewTestObjectButton.Size = new System.Drawing.Size(75, 23);
            this.NewTestObjectButton.TabIndex = 29;
            this.NewTestObjectButton.Text = "New Object";
            this.NewTestObjectButton.UseVisualStyleBackColor = true;
            this.NewTestObjectButton.Click += new System.EventHandler(this.NewTestObjectButton_Click);
            // 
            // ConsoleTextBox
            // 
            this.ConsoleTextBox.Location = new System.Drawing.Point(9, 158);
            this.ConsoleTextBox.Multiline = true;
            this.ConsoleTextBox.Name = "ConsoleTextBox";
            this.ConsoleTextBox.ReadOnly = true;
            this.ConsoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ConsoleTextBox.Size = new System.Drawing.Size(542, 230);
            this.ConsoleTextBox.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Class column";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Select rows";
            // 
            // ClassTextBox
            // 
            this.ClassTextBox.Location = new System.Drawing.Point(141, 60);
            this.ClassTextBox.Name = "ClassTextBox";
            this.ClassTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClassTextBox.TabIndex = 23;
            // 
            // SelectTextBox
            // 
            this.SelectTextBox.Location = new System.Drawing.Point(12, 61);
            this.SelectTextBox.Name = "SelectTextBox";
            this.SelectTextBox.Size = new System.Drawing.Size(100, 20);
            this.SelectTextBox.TabIndex = 22;
            // 
            // InfoToolStripButton
            // 
            this.InfoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.InfoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("InfoToolStripButton.Image")));
            this.InfoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InfoToolStripButton.Name = "InfoToolStripButton";
            this.InfoToolStripButton.Size = new System.Drawing.Size(32, 22);
            this.InfoToolStripButton.Text = "Info";
            this.InfoToolStripButton.Click += new System.EventHandler(this.InfoToolStripButton_Click);
            // 
            // NaiveBayesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 404);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.NewObjectTextBox);
            this.Controls.Add(this.NewTestObjectButton);
            this.Controls.Add(this.ConsoleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassTextBox);
            this.Controls.Add(this.SelectTextBox);
            this.Name = "NaiveBayesForm";
            this.Text = "NaiveBayes";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenToolStripButton;
        private System.Windows.Forms.ToolStripButton CalculateToolStripButton;
        private System.Windows.Forms.TextBox NewObjectTextBox;
        private System.Windows.Forms.Button NewTestObjectButton;
        private System.Windows.Forms.TextBox ConsoleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClassTextBox;
        private System.Windows.Forms.TextBox SelectTextBox;
        private System.Windows.Forms.ToolStripButton InfoToolStripButton;
    }
}