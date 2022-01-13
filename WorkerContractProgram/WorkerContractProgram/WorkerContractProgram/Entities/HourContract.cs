using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerContractProgram.Entities
{
    internal class HourContract
    {
        public DateTime date;
        public double valuePerHour;
        public int hours;

        public double totalValue()
        {
            return 0.0;
        }
    }
}
