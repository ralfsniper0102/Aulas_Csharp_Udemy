using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerContractProgram.Entities.Enums;

namespace WorkerContractProgram.Entities
{
    internal class Worker
    {
        public String name;
        public WorkerLevel level;
        public double baseSalary;

        public void addContract(HourContract contract)
        {

        }

        public void removeContract(HourContract contract)
        {

        }
        public double income(int year, int month)
        {
            return 0.0;
        }


    }
}
