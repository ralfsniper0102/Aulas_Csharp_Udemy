using System;
using System.Globalization;

namespace Soma_Params
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("Quantos numeros deseja soma? ");
            int quantidade = int.Parse(Console.ReadLine());
            double[] valores = new double[quantidade];

            for (int i = 0 ; i <quantidade;i++ )
            {
                valores[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine(Calculadora.Soma(valores).ToString("F2", CultureInfo.InvariantCulture));*/




            Console.WriteLine(Calculadora.Soma(1,2,3).ToString("F2", CultureInfo.InvariantCulture)); 
        }
    }
}
