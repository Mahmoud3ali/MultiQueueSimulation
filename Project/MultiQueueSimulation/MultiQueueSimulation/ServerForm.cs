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
    public partial class ServerForm : Form
    {
        int Count;
        SimulationSystem Program;
        public ServerForm(ref SimulationSystem Program, int count)
        {
            InitializeComponent();
            this.Count = count;
            this.Program = Program;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            int Range = 1;
            decimal cumulative = 0;
            Server current = new Server();
            current.ID = Program.Servers.Count + 1;
            for (int rows = 0; rows < ServerGrid.RowCount - 1; rows++)
            {
                TimeDistribution tmp = new TimeDistribution();
                tmp.Time = Int32.Parse(ServerGrid.Rows[rows].Cells[0].Value.ToString());
                tmp.Probability = Decimal.Parse(ServerGrid.Rows[rows].Cells[1].Value.ToString());
                tmp.CummProbability = tmp.Probability + cumulative;
                cumulative = tmp.CummProbability;
                tmp.MinRange = Range + 1;
                tmp.MaxRange = Convert.ToInt32( cumulative * 100);
                Range = tmp.MaxRange;
                current.TimeDistribution.Add(tmp);
            }
            Program.Servers.Add(current);
            if (Count == 0)
            {
                Results form = new Results(ref Program);
                form.Show();
                this.Close();
            }
            else
            {
                ServerForm form = new ServerForm(ref Program, Count - 1);
                form.Show();
                this.Close();
            }
        }
    }
}
