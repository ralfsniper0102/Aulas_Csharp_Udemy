using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramTaxpayer.Entities;

namespace ProgramTaxpayer.Entities
{
    class Company : Taxpayer
    {
        public int NumberEmployees { get; set; }

        public Company()
        {

        }

        public Company(string name, double anualIncome, int numberEmployees)
            : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double TaxesPaid()
        {
            double taxes = 0.0;
            if (NumberEmployees > 10)
            {
                taxes = AnualIncome * 0.14;
            }
            else
            {
                taxes = AnualIncome * 0.16;
            }
            

            return taxes;
        }
    }
}
