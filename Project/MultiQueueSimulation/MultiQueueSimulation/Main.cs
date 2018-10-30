using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;
using MultiQueueTesting;

namespace MultiQueueSimulation
{
    public partial class Main : Form
    {
        SimulationSystem Program;
        public Main()
        {
            InitializeComponent();
            Program = new SimulationSystem();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            int Range = 1;
            decimal cumulative = 0;
            for (int rows = 0; rows < ClientGrid.RowCount - 1; rows++)
            {
                TimeDistribution tmp = new TimeDistribution();
                tmp.Time = Int32.Parse(ClientGrid.Rows[rows].Cells[0].Value.ToString());
                tmp.Probability = Decimal.Parse(ClientGrid.Rows[rows].Cells[1].Value.ToString());
                cumulative += tmp.Probability;
                tmp.MinRange = Range;
                tmp.MaxRange = (int)(cumulative * 100);
                tmp.CummProbability = cumulative;
                Range = tmp.MaxRange + 1;
                Program.InterarrivalDistribution.Add(tmp);
            }
            int Count = Int32.Parse(ServersCount.Text);
            Program.NumberOfServers = Count;
            ServerForm form = new ServerForm(ref Program, Count - 1);
            form.Show();
        }
    }
}
