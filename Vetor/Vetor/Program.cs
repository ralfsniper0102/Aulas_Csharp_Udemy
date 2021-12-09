using System;
using System.Globalization;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] v1 = new double[3];

            for (int i=0;i<3 ;i++ )
            {
                v1[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for (int i = 0; i<3 ;i++ )
            {
                soma = soma + v1[i];
            }

            double media = (soma / 3);

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

           

        }
    }
}
