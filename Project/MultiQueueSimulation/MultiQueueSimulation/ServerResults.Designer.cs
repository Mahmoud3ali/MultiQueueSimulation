namespace MultiQueueSimulation
{
    partial class ServerResults
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.ResultsGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultsGraph
            // 
            chartArea1.Name = "Busy";
            this.ResultsGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ResultsGraph.Legends.Add(legend1);
            this.ResultsGraph.Location = new System.Drawing.Point(1, 1);
            this.ResultsGraph.Name = "ResultsGraph";
            this.ResultsGraph.Size = new System.Drawing.Size(918, 383);
            this.ResultsGraph.TabIndex = 0;
            this.ResultsGraph.Text = "chart1";
            // 
            // ServerResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 385);
            this.Controls.Add(this.ResultsGraph);
            this.Name = "ServerResults";
            this.Text = "ServerResults";
            ((System.ComponentModel.ISupportInitialize)(this.ResultsGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ResultsGraph;
    }
}