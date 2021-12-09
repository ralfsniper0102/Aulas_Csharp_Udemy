using System;
using System.Globalization;

namespace MediaProdutos_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a quantidade de produtos");
            int quantidade = int.Parse(Console.ReadLine());

            Produto[] x = new Produto[quantidade];

            for (int i = 0; i <quantidade ;i++ )
            {
                Console.WriteLine("Digite o nome do produto: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto: ");
                double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                x[i] = new Produto(nome, preco);
            }

            double soma = 0.0;
            for (int i = 0; i < quantidade; i++)
            {
                soma = soma + x[i].Preco;
            }

            double media = soma / quantidade;

            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
