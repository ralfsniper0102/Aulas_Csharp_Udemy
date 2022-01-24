using ProgramProductRegistration.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProgramProductRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Entre com a quantidade de produtos a ser cadastrados: ");
            int quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine("Dados do produto #" + (i+1));
                Console.Write("Comum, usado ou importado (c/u/i)? ");
                char yesOrNo = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                switch (yesOrNo)
                {
                    case 'c':
                        products.Add(new Product(name, price));
                        break;
                    case 'u':
                        Console.Write("Data de Validade (DD/MM/AAAA): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, manufactureDate));
                        break;
                    case 'i':
                        Console.Write("Taxa Alfandegária: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        products.Add(new ImportedProduct(name, price, customsFee));
                        break;
                    default:
                        Console.WriteLine("Produto não cadastrado");
                        break;
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Etiqueta de Preços:");

            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
