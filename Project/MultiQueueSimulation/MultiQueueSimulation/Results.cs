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
    public partial class Results : Form
    {
        SimulationSystem Program;
        public Results(ref SimulationSystem Program)
        {
            InitializeComponent();
            this.Program = Program;
        }
        private int SimulationReady()
        {
            if (!((Customer.Checked == true || Time.Checked == true) && (Input.Text.Length != 0) &&
                (Priority.Checked == true || Utilization.Checked == true || Random.Checked == true)))
                return -1;
            Program.StoppingNumber = Int32.Parse(Input.Text);
            if (Customer.Checked == true)
                Program.StoppingCriteria = Enums.StoppingCriteria.NumberOfCustomers;
            else
                Program.StoppingCriteria = Enums.StoppingCriteria.SimulationEndTime;

            if (Priority.Checked == true) Program.SelectionMethod = Enums.SelectionMethod.HighestPriority;
            if (Utilization.Checked == true) Program.SelectionMethod = Enums.SelectionMethod.LeastUtilization;
            if (Random.Checked == true) Program.SelectionMethod = Enums.SelectionMethod.Random;
            return 0;
        }
        private void View()
        {
            Output.Rows.Add(Program.SimulationTable.Count);
            for(int i = 0; i < Program.SimulationTable.Count; i++)
            {
                Output.Rows[i].Cells[0].Value = Program.SimulationTable[i].CustomerNumber.ToString();
                Output.Rows[i].Cells[1].Value = Program.SimulationTable[i].RandomInterArrival.ToString();
                Output.Rows[i].Cells[2].Value = Program.SimulationTable[i].InterArrival.ToString();
                Output.Rows[i].Cells[3].Value = Program.SimulationTable[i].ArrivalTime.ToString();
                Output.Rows[i].Cells[4].Value = Program.SimulationTable[i].RandomService.ToString();
                Output.Rows[i].Cells[5].Value = Program.SimulationTable[i].AssignedServer.ID.ToString();
                Output.Rows[i].Cells[6].Value = Program.SimulationTable[i].StartTime.ToString();
                Output.Rows[i].Cells[7].Value = Program.SimulationTable[i].ServiceTime.ToString();
                Output.Rows[i].Cells[8].Value = Program.SimulationTable[i].EndTime.ToString();
                Output.Rows[i].Cells[9].Value = Program.SimulationTable[i].TimeInQueue.ToString();
            }
            for (int i = 0; i < Program.Servers.Count; i++)
            {
                ServerResults form = new ServerResults(i,Program);
                form.Show();
            }
        }
        private void Simulate_Click(object sender, EventArgs e)
        {
            if(SimulationReady() == -1)
                MessageBox.Show("Make sure you have filled all the fields");
            else
            {
                Program.Run();
                View();
                string testingResult = TestingManager.Test(Program, Constants.FileNames.TestCase1);
                MessageBox.Show(testingResult);
            }
        }
    }
}
