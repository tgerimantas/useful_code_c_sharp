namespace ClusteringAlgorithmsDataMining
{
    partial class MainForm
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
            this.mainLable = new System.Windows.Forms.Label();
            this.openKMeansButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainLable
            // 
            this.mainLable.AutoSize = true;
            this.mainLable.Location = new System.Drawing.Point(124, 36);
            this.mainLable.Name = "mainLable";
            this.mainLable.Size = new System.Drawing.Size(104, 13);
            this.mainLable.TabIndex = 0;
            this.mainLable.Text = "Clustering Algorithms";
            // 
            // openKMeansButton
            // 
            this.openKMeansButton.Location = new System.Drawing.Point(51, 104);
            this.openKMeansButton.Name = "openKMeansButton";
            this.openKMeansButton.Size = new System.Drawing.Size(75, 23);
            this.openKMeansButton.TabIndex = 1;
            this.openKMeansButton.Text = "KMeans";
            this.openKMeansButton.UseVisualStyleBackColor = true;
            this.openKMeansButton.Click += new System.EventHandler(this.openKMeansButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "DBSCAN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 176);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.openKMeansButton);
            this.Controls.Add(this.mainLable);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLable;
        private System.Windows.Forms.Button openKMeansButton;
        private System.Windows.Forms.Button button2;
    }
}