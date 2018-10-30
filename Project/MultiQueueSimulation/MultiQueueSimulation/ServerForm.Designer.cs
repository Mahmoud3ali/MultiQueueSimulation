namespace MultiQueueSimulation
{
    partial class ServerForm
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
            this.Next = new System.Windows.Forms.Button();
            this.ServerGrid = new System.Windows.Forms.DataGridView();
            this.ServiceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ServerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(138, 362);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(103, 23);
            this.Next.TabIndex = 10;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // ServerGrid
            // 
            this.ServerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceTime,
            this.Probability});
            this.ServerGrid.Location = new System.Drawing.Point(76, 53);
            this.ServerGrid.Name = "ServerGrid";
            this.ServerGrid.Size = new System.Drawing.Size(241, 267);
            this.ServerGrid.TabIndex = 7;
            // 
            // ServiceTime
            // 
            this.ServiceTime.HeaderText = "ServiceTime";
            this.ServiceTime.Name = "ServiceTime";
            // 
            // Probability
            // 
            this.Probability.HeaderText = "Probability";
            this.Probability.Name = "Probability";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Service Input";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.ServerGrid);
            this.Controls.Add(this.label1);
            this.Name = "ServerForm";
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.ServerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.DataGridView ServerGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probability;
    }
}