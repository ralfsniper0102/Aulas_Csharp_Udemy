using System;
using System.Globalization;
namespace ConversorDeMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do Dolar?: ");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Console.Write("Quantos dolares você irá comprar? ");
            double dolarComprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Valor a ser pago em reais = ");
            Console.WriteLine(CalculadoraDolar.CalcularCompraDolar(cotacao, dolarComprar).ToString("F2",CultureInfo.InvariantCulture)); 

           
        }
    }
}
