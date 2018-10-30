using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class PerformanceMeasures
    {
        public PerformanceMeasures()
        {
            AverageWaitingTime = 0;
            MaxQueueLength = 0;
            WaitingProbability = 0;
        }
        public decimal AverageWaitingTime { get; set; }
        public int MaxQueueLength { get; set; }
        public decimal WaitingProbability { get; set; }
    }
}
