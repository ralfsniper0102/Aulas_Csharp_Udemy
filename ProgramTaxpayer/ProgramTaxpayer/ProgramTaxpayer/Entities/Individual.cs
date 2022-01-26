using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramTaxpayer.Entities;



namespace ProgramTaxpayer.Entities
{
    class Individual : Taxpayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {

        }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base (name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesPaid()
        {
            return 0.0;
        }
    }
}
