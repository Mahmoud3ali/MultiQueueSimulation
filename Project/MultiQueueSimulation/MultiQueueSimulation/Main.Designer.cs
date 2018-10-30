namespace MultiQueueSimulation
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.ClientGrid = new System.Windows.Forms.DataGridView();
            this.InterarrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServersCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.ReadFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interarrival Input";
            // 
            // ClientGrid
            // 
            this.ClientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InterarrivalTime,
            this.Probability});
            this.ClientGrid.Location = new System.Drawing.Point(82, 63);
            this.ClientGrid.Name = "ClientGrid";
            this.ClientGrid.Size = new System.Drawing.Size(241, 267);
            this.ClientGrid.TabIndex = 2;
            // 
            // InterarrivalTime
            // 
            this.InterarrivalTime.HeaderText = "InterarrivalTime";
            this.InterarrivalTime.Name = "InterarrivalTime";
            // 
            // Probability
            // 
            this.Probability.HeaderText = "Probability";
            this.Probability.Name = "Probability";
            // 
            // ServersCount
            // 
            this.ServersCount.Location = new System.Drawing.Point(210, 363);
            this.ServersCount.Name = "ServersCount";
            this.ServersCount.Size = new System.Drawing.Size(100, 20);
            this.ServersCount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Server(s)";
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(82, 411);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(103, 23);
            this.Next.TabIndex = 5;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // ReadFile
            // 
            this.ReadFile.Location = new System.Drawing.Point(220, 411);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(103, 23);
            this.ReadFile.TabIndex = 6;
            this.ReadFile.Text = "Read File";
            this.ReadFile.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 446);
            this.Controls.Add(this.ReadFile);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServersCount);
            this.Controls.Add(this.ClientGrid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.ClientGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ClientGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterarrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probability;
        private System.Windows.Forms.TextBox ServersCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button ReadFile;
    }
}

