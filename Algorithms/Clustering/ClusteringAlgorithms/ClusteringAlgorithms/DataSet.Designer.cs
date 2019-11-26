namespace ClusteringAlgorithmsDataMining
{
    partial class DataSet
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.SelectColumnsButton = new System.Windows.Forms.Button();
            this.yColumnTextBox = new System.Windows.Forms.TextBox();
            this.xColumnTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(523, 438);
            this.dataGridView.TabIndex = 0;
            // 
            // SelectColumnsButton
            // 
            this.SelectColumnsButton.Location = new System.Drawing.Point(457, 454);
            this.SelectColumnsButton.Name = "SelectColumnsButton";
            this.SelectColumnsButton.Size = new System.Drawing.Size(75, 23);
            this.SelectColumnsButton.TabIndex = 9;
            this.SelectColumnsButton.Text = "Set";
            this.SelectColumnsButton.UseVisualStyleBackColor = true;
            this.SelectColumnsButton.Click += new System.EventHandler(this.SelectColumnsButton_Click);
            // 
            // yColumnTextBox
            // 
            this.yColumnTextBox.Location = new System.Drawing.Point(152, 456);
            this.yColumnTextBox.Name = "yColumnTextBox";
            this.yColumnTextBox.Size = new System.Drawing.Size(44, 20);
            this.yColumnTextBox.TabIndex = 8;
            // 
            // xColumnTextBox
            // 
            this.xColumnTextBox.Location = new System.Drawing.Point(50, 456);
            this.xColumnTextBox.Name = "xColumnTextBox";
            this.xColumnTextBox.Size = new System.Drawing.Size(44, 20);
            this.xColumnTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            // 
            // DataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 488);
            this.Controls.Add(this.SelectColumnsButton);
            this.Controls.Add(this.yColumnTextBox);
            this.Controls.Add(this.xColumnTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Name = "DataSet";
            this.Text = "DataSet";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button SelectColumnsButton;
        private System.Windows.Forms.TextBox yColumnTextBox;
        private System.Windows.Forms.TextBox xColumnTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}