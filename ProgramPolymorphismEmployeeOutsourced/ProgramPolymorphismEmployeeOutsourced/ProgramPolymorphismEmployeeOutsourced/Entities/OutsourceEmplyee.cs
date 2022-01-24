using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProgramPolymorphism.Entities
{
    class OutsourceEmplyee : Employee
    {
        public double AdditionalCharge { get; set; }

        //List<OutsourceEmplyee> outsourceEmplyees = new List<OutsourceEmplyee>();

        public OutsourceEmplyee()
        {
        }
        public OutsourceEmplyee(string name, int hours, double valuePerHours, Double additionalCharge) :
            base(name, hours, valuePerHours)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return (base.Payment() + (AdditionalCharge * 1.1));

        }
    }
}
