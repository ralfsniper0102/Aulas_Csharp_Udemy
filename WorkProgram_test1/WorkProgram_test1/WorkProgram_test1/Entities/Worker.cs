using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkProgram_test1.Entities.Enum;

namespace WorkProgram_test1.Entities
{
    class Worker
    {
        public string Nome { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Departament Departament { get; set; }

        List<HourContract> contracts = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string nome, WorkerLevel level, double baseSalary, Departament departament)
        {
            Nome = nome;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in contracts)
            {
                
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum = sum + contract.TotalValue();
                } 
            }    
            return sum;
        }


    }
}
