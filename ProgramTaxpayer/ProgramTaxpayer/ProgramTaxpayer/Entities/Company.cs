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

        public Company(int numberEmployees, string name, double anualIncome)
            : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double TaxesPaid()
        {
            return 0.0;
        }
    }
}
