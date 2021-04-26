using System;
using System.Globalization;

namespace ConsoleApp3
{
    class Program
        
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            string[] txt1 = Console.ReadLine().Split(' ');
            double tri1a = double.Parse(txt1[0], CultureInfo.InvariantCulture);
            double tri1b = double.Parse(txt1[1], CultureInfo.InvariantCulture);
            double tri1c = double.Parse(txt1[2], CultureInfo.InvariantCulture); 
            
            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            string[] txt2 = Console.ReadLine().Split(' ');
            double tri2a = double.Parse(txt2[0], CultureInfo.InvariantCulture);
            double tri2b = double.Parse(txt2[1], CultureInfo.InvariantCulture);
            double tri2c = double.Parse(txt2[2], CultureInfo.InvariantCulture);

            double areax = area_tringulo(tri1a, tri1b, tri1c);
            double areay = area_tringulo(tri2a, tri2b, tri2c);

            Console.WriteLine(areax.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine(areay.ToString("F4", CultureInfo.InvariantCulture));

            if (areax > areay)
            {
                Console.WriteLine("X é o maior");
            }
            else
            {
                Console.WriteLine("Y é o maior");
            }



        }
        static double area_tringulo(double a, double b, double c)
        {
            
            
            double p = ((a + b + c) / 2);
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));


            return (area);
        }



    }
}
