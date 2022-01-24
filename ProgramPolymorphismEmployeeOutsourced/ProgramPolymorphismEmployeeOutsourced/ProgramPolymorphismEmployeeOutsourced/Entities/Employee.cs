using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramPolymorphism.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        //List<Employee> Employees = new List<Employee>();
        
        public Employee()
        {

        }
        
        public Employee(string name, int hours, double valuePerHours)
        {
            Name = name;    
            Hours = hours;
            ValuePerHour = valuePerHours;
        }

        public virtual double Payment()
        {
            return (Hours * ValuePerHour);
        }
    }
}
