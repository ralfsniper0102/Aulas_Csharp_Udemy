using System;
using System.Globalization;

namespace ConsoleApp3
{
    class Program
        
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três valores:");
            string[] vs = Console.ReadLine().Split(' ');
            double v1 = double.Parse(vs[0], CultureInfo.InvariantCulture);
            double v2 = double.Parse(vs[1], CultureInfo.InvariantCulture);
            double v3 = double.Parse(vs[2], CultureInfo.InvariantCulture);

            Maior(v1, v2, v3);

        }

        static double Maior(double v1, double v2, double v3)
        {
            double m=0;
            if (v1 > v2 && v1 > v3)
            {
                Console.WriteLine(v1.ToString(CultureInfo.InvariantCulture) + " é o Maior");
            }
            else if (v2 > v1 && v2 > v3)
            {
                Console.WriteLine(v2.ToString(CultureInfo.InvariantCulture) + " é o Maior");
            }
            else if (v3 > v1 && v3 > v2)
            {
                Console.WriteLine(v3.ToString(CultureInfo.InvariantCulture) + " é o Maior");
            }
            else
            {
                Console.WriteLine("Os valores São iguais");
            }
            return m;
        }
    }
}
