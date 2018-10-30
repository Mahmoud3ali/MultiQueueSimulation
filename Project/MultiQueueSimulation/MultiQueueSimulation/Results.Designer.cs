namespace MultiQueueSimulation
{
    partial class Results
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
            this.Output = new System.Windows.Forms.DataGridView();
            this.CustomerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RndArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBetween = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RndService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeInQueue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.RadioButton();
            this.Time = new System.Windows.Forms.RadioButton();
            this.Input = new System.Windows.Forms.TextBox();
            this.Random = new System.Windows.Forms.RadioButton();
            this.Utilization = new System.Windows.Forms.RadioButton();
            this.Priority = new System.Windows.Forms.RadioButton();
            this.Simulate = new System.Windows.Forms.Button();
            this.StoppingGroup = new System.Windows.Forms.GroupBox();
            this.SelectionGroup = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Output)).BeginInit();
            this.StoppingGroup.SuspendLayout();
            this.SelectionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.AllowUserToAddRows = false;
            this.Output.AllowUserToDeleteRows = false;
            this.Output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Output.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerNo,
            this.RndArrival,
            this.TimeBetween,
            this.ArrivalTime,
            this.RndService,
            this.ServerID,
            this.ServiceBegin,
            this.ServiceTime,
            this.ServiceEnd,
            this.TimeInQueue});
            this.Output.Location = new System.Drawing.Point(0, -1);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(1047, 478);
            this.Output.TabIndex = 0;
            // 
            // CustomerNo
            // 
            this.CustomerNo.Frozen = true;
            this.CustomerNo.HeaderText = "CustomerNo";
            this.CustomerNo.Name = "CustomerNo";
            this.CustomerNo.ReadOnly = true;
            // 
            // RndArrival
            // 
            this.RndArrival.Frozen = true;
            this.RndArrival.HeaderText = "RndArrival";
            this.RndArrival.Name = "RndArrival";
            this.RndArrival.ReadOnly = true;
            // 
            // TimeBetween
            // 
            this.TimeBetween.Frozen = true;
            this.TimeBetween.HeaderText = "TimeBetween";
            this.TimeBetween.Name = "TimeBetween";
            this.TimeBetween.ReadOnly = true;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.Frozen = true;
            this.ArrivalTime.HeaderText = "ArrivalTime";
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.ReadOnly = true;
            // 
            // RndService
            // 
            this.RndService.Frozen = true;
            this.RndService.HeaderText = "RndService";
            this.RndService.Name = "RndService";
            this.RndService.ReadOnly = true;
            // 
            // ServerID
            // 
            this.ServerID.Frozen = true;
            this.ServerID.HeaderText = "ServerID";
            this.ServerID.Name = "ServerID";
            this.ServerID.ReadOnly = true;
            // 
            // ServiceBegin
            // 
            this.ServiceBegin.Frozen = true;
            this.ServiceBegin.HeaderText = "ServiceBegin";
            this.ServiceBegin.Name = "ServiceBegin";
            this.ServiceBegin.ReadOnly = true;
            // 
            // ServiceTime
            // 
            this.ServiceTime.Frozen = true;
            this.ServiceTime.HeaderText = "ServiceTime";
            this.ServiceTime.Name = "ServiceTime";
            this.ServiceTime.ReadOnly = true;
            // 
            // ServiceEnd
            // 
            this.ServiceEnd.Frozen = true;
            this.ServiceEnd.HeaderText = "ServiceEnd";
            this.ServiceEnd.Name = "ServiceEnd";
            this.ServiceEnd.ReadOnly = true;
            // 
            // TimeInQueue
            // 
            this.TimeInQueue.HeaderText = "TimeInQueue";
            this.TimeInQueue.Name = "TimeInQueue";
            this.TimeInQueue.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.Location = new System.Drawing.Point(17, 19);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(173, 17);
            this.Customer.TabIndex = 1;
            this.Customer.TabStop = true;
            this.Customer.Text = "Maximum Number of Customers";
            this.Customer.UseVisualStyleBackColor = true;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(17, 42);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(121, 17);
            this.Time.TabIndex = 2;
            this.Time.TabStop = true;
            this.Time.Text = "Simulation End Time";
            this.Time.UseVisualStyleBackColor = true;
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(216, 29);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(100, 20);
            this.Input.TabIndex = 3;
            // 
            // Random
            // 
            this.Random.AutoSize = true;
            this.Random.Location = new System.Drawing.Point(6, 46);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(65, 17);
            this.Random.TabIndex = 4;
            this.Random.TabStop = true;
            this.Random.Text = "Random";
            this.Random.UseVisualStyleBackColor = true;
            // 
            // Utilization
            // 
            this.Utilization.AutoSize = true;
            this.Utilization.Location = new System.Drawing.Point(6, 69);
            this.Utilization.Name = "Utilization";
            this.Utilization.Size = new System.Drawing.Size(99, 17);
            this.Utilization.TabIndex = 5;
            this.Utilization.TabStop = true;
            this.Utilization.Text = "Least Utilization";
            this.Utilization.UseVisualStyleBackColor = true;
            // 
            // Priority
            // 
            this.Priority.AutoSize = true;
            this.Priority.Location = new System.Drawing.Point(6, 23);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(56, 17);
            this.Priority.TabIndex = 6;
            this.Priority.TabStop = true;
            this.Priority.Text = "Priority";
            this.Priority.UseVisualStyleBackColor = true;
            // 
            // Simulate
            // 
            this.Simulate.Location = new System.Drawing.Point(679, 503);
            this.Simulate.Name = "Simulate";
            this.Simulate.Size = new System.Drawing.Size(176, 54);
            this.Simulate.TabIndex = 7;
            this.Simulate.Text = "Simulate";
            this.Simulate.UseVisualStyleBackColor = true;
            this.Simulate.Click += new System.EventHandler(this.Simulate_Click);
            // 
            // StoppingGroup
            // 
            this.StoppingGroup.Controls.Add(this.Customer);
            this.StoppingGroup.Controls.Add(this.Time);
            this.StoppingGroup.Controls.Add(this.Input);
            this.StoppingGroup.Location = new System.Drawing.Point(40, 492);
            this.StoppingGroup.Name = "StoppingGroup";
            this.StoppingGroup.Size = new System.Drawing.Size(322, 77);
            this.StoppingGroup.TabIndex = 8;
            this.StoppingGroup.TabStop = false;
            this.StoppingGroup.Text = "Stopping Condition";
            // 
            // SelectionGroup
            // 
            this.SelectionGroup.Controls.Add(this.Random);
            this.SelectionGroup.Controls.Add(this.Utilization);
            this.SelectionGroup.Controls.Add(this.Priority);
            this.SelectionGroup.Location = new System.Drawing.Point(422, 483);
            this.SelectionGroup.Name = "SelectionGroup";
            this.SelectionGroup.Size = new System.Drawing.Size(187, 90);
            this.SelectionGroup.TabIndex = 9;
            this.SelectionGroup.TabStop = false;
            this.SelectionGroup.Text = "Server Selection Method";
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 604);
            this.Controls.Add(this.SelectionGroup);
            this.Controls.Add(this.StoppingGroup);
            this.Controls.Add(this.Simulate);
            this.Controls.Add(this.Output);
            this.Name = "Results";
            this.Text = "Results";
            ((System.ComponentModel.ISupportInitialize)(this.Output)).EndInit();
            this.StoppingGroup.ResumeLayout(false);
            this.StoppingGroup.PerformLayout();
            this.SelectionGroup.ResumeLayout(false);
            this.SelectionGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Output;
        private System.Windows.Forms.RadioButton Customer;
        private System.Windows.Forms.RadioButton Time;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.RadioButton Random;
        private System.Windows.Forms.RadioButton Utilization;
        private System.Windows.Forms.RadioButton Priority;
        private System.Windows.Forms.Button Simulate;
        private System.Windows.Forms.GroupBox StoppingGroup;
        private System.Windows.Forms.GroupBox SelectionGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RndArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBetween;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn RndService;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeInQueue;
    }
}