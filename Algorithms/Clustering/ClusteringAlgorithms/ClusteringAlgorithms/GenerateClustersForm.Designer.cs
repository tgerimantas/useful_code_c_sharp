namespace ClusteringAlgorithmsDataMining
{
    partial class GenerateClustersForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.clustersTextBox = new System.Windows.Forms.TextBox();
            this.SetRandomDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Clusters";
            // 
            // clustersTextBox
            // 
            this.clustersTextBox.Location = new System.Drawing.Point(59, 12);
            this.clustersTextBox.Name = "clustersTextBox";
            this.clustersTextBox.Size = new System.Drawing.Size(46, 20);
            this.clustersTextBox.TabIndex = 15;
            // 
            // SetRandomDataButton
            // 
            this.SetRandomDataButton.Location = new System.Drawing.Point(81, 61);
            this.SetRandomDataButton.Name = "SetRandomDataButton";
            this.SetRandomDataButton.Size = new System.Drawing.Size(75, 23);
            this.SetRandomDataButton.TabIndex = 18;
            this.SetRandomDataButton.Text = "Set";
            this.SetRandomDataButton.UseVisualStyleBackColor = true;
            this.SetRandomDataButton.Click += new System.EventHandler(this.SetRandomDataButton_Click);
            // 
            // GenerateClusters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 96);
            this.Controls.Add(this.SetRandomDataButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clustersTextBox);
            this.Name = "GenerateClusters";
            this.Text = "GenerateClusters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clustersTextBox;
        private System.Windows.Forms.Button SetRandomDataButton;
    }
}