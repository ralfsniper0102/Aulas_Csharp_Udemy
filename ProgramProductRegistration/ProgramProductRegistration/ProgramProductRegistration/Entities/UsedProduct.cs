using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramProductRegistration.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name
               + " (used)"
               + " $ "
               + Price.ToString("F2", CultureInfo.InvariantCulture)
               + " (Data de Validade: "
               + ManufactureDate.ToString("dd/MM/yyyy")
               + ")"
               ;
        }
    }
}
