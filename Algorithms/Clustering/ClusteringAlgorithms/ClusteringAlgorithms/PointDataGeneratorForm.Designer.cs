namespace ClusteringAlgorithmsDataMining
{
    partial class PointDataGeneratorForm
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
            this.SetRandomDataButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pointsTextBox = new System.Windows.Forms.TextBox();
            this.minXTextBox = new System.Windows.Forms.TextBox();
            this.maxXTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minYTextBox = new System.Windows.Forms.TextBox();
            this.maxYTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SetRandomDataButton
            // 
            this.SetRandomDataButton.Location = new System.Drawing.Point(121, 116);
            this.SetRandomDataButton.Name = "SetRandomDataButton";
            this.SetRandomDataButton.Size = new System.Drawing.Size(75, 23);
            this.SetRandomDataButton.TabIndex = 26;
            this.SetRandomDataButton.Text = "Set";
            this.SetRandomDataButton.UseVisualStyleBackColor = true;
            this.SetRandomDataButton.Click += new System.EventHandler(this.SetRandomDataButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "MaxX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "MinX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Points";
            // 
            // pointsTextBox
            // 
            this.pointsTextBox.Location = new System.Drawing.Point(54, 16);
            this.pointsTextBox.Name = "pointsTextBox";
            this.pointsTextBox.Size = new System.Drawing.Size(46, 20);
            this.pointsTextBox.TabIndex = 21;
            // 
            // minXTextBox
            // 
            this.minXTextBox.Location = new System.Drawing.Point(54, 45);
            this.minXTextBox.Name = "minXTextBox";
            this.minXTextBox.Size = new System.Drawing.Size(46, 20);
            this.minXTextBox.TabIndex = 19;
            // 
            // maxXTextBox
            // 
            this.maxXTextBox.Location = new System.Drawing.Point(160, 45);
            this.maxXTextBox.Name = "maxXTextBox";
            this.maxXTextBox.Size = new System.Drawing.Size(46, 20);
            this.maxXTextBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "MaxY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "MinY";
            // 
            // minYTextBox
            // 
            this.minYTextBox.Location = new System.Drawing.Point(54, 71);
            this.minYTextBox.Name = "minYTextBox";
            this.minYTextBox.Size = new System.Drawing.Size(46, 20);
            this.minYTextBox.TabIndex = 28;
            // 
            // maxYTextBox
            // 
            this.maxYTextBox.Location = new System.Drawing.Point(160, 71);
            this.maxYTextBox.Name = "maxYTextBox";
            this.maxYTextBox.Size = new System.Drawing.Size(46, 20);
            this.maxYTextBox.TabIndex = 27;
            // 
            // PointDataGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 160);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.minYTextBox);
            this.Controls.Add(this.maxYTextBox);
            this.Controls.Add(this.SetRandomDataButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pointsTextBox);
            this.Controls.Add(this.minXTextBox);
            this.Controls.Add(this.maxXTextBox);
            this.Name = "PointDataGeneratorForm";
            this.Text = "RandomDataGeneratorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetRandomDataButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pointsTextBox;
        private System.Windows.Forms.TextBox minXTextBox;
        private System.Windows.Forms.TextBox maxXTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox minYTextBox;
        private System.Windows.Forms.TextBox maxYTextBox;
    }
}