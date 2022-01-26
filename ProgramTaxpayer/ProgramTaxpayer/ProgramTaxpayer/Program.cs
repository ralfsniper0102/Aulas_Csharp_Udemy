using System;

namespace ProgramTaxpayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número de contribuintes: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.Write("Contribuinte Físico ou Jurídico (f/j)?");
            char TaxpayerType = char.Parse(Console.ReadLine().ToLower());

            string name;
            double anualIncome;
            double healthExpenditures;

            switch (TaxpayerType)
            {
                case 'f':
                    Console.Write("Nome: ");
                    name = Console.ReadLine();
                    Console.Write("Renda Anual: ");
                    anualIncome = double.Parse(Console.ReadLine());
                    Console.Write("Despesas de Saúde: ");
                    healthExpenditures = double.Parse(Console.ReadLine());   


                    break;
                case 'j':
                    Console.Write("Nome: ");
                    name = Console.ReadLine();
                    Console.Write("Renda Anual: ");
                    anualIncome = double.Parse(Console.ReadLine());
                    Console.Write("Número de Empregados: ");
                    int employees = int.Parse(Console.ReadLine());


                    break;
                default:
                    break;
            }
        }
    }
}
