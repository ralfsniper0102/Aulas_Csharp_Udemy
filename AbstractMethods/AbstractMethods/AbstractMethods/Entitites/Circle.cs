using AbstractMethods.Entitites.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethods.Entitites
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {

        }

        public Circle(double radius, Color color)
            : base (color) 
        {
            Radius = radius;
        }

        public override double Area()
        {
            return 0;
        }
    }
}
