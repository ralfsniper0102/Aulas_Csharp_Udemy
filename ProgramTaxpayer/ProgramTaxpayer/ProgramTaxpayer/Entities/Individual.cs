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
            double taxes = 0.0;
            if(AnualIncome > 20000)
            {
                taxes = AnualIncome * 0.25;

                if(HealthExpenditures > 0.0)
                {
                    taxes = taxes - (HealthExpenditures / 2);
                }
                
            }
            else
            {
                taxes = AnualIncome * 0.15;
                if (HealthExpenditures > 0.0)
                {
                    taxes = taxes - (HealthExpenditures / 2);
                }
            }

            return taxes;
        }
    }
}
