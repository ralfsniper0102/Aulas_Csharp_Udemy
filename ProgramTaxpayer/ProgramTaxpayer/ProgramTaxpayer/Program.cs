using ProgramTaxpayer.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProgramTaxpayer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taxpayer> taxpayers = new List<Taxpayer>();

            Console.Write("Entre com o número de contribuintes: ");
            int quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine("Pagador de Imposto #" + (i+1));
                Console.Write("Contribuinte Físico ou Jurídico (f/j)? ");
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
                        anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Despesas de Saúde: ");
                        healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        taxpayers.Add(new Individual(name, anualIncome, healthExpenditures));

                        break;
                    case 'j':
                        Console.Write("Nome: ");
                        name = Console.ReadLine();
                        Console.Write("Renda Anual: ");
                        anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Número de Empregados: ");
                        int employees = int.Parse(Console.ReadLine());

                        taxpayers.Add(new Company(name, anualIncome, employees));


                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Impostos Pagos: ");

            double totalTaxes = 0.0;
            foreach (Taxpayer taxpayer in taxpayers)
            {
                Console.WriteLine(taxpayer.Name + ": $ " + taxpayer.TaxesPaid().ToString("F2", CultureInfo.InvariantCulture));
                totalTaxes = totalTaxes + taxpayer.TaxesPaid();
            }

            Console.WriteLine("Total de Taxas: " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
