using AbstractMethods.Entitites.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethods.Entitites
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        Rectangle()
        {

        }

        public Rectangle(double width, double height, Color color)
            : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return (Width * Height);
        }
    }
}
