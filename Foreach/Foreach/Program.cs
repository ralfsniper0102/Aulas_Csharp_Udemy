using System;
using System.Globalization;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma quantidade");
            int quantidade = int.Parse(Console.ReadLine());

            Pessoa[] x = new Pessoa[quantidade];
            
            for (int i = 0 ; i<quantidade ; i++ )
            {
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Idade: ");
                int idade = int.Parse(Console.ReadLine());

                x[i] = new Pessoa(nome, idade);
            }

            foreach(Pessoa obj in x)
            {
                Console.WriteLine(obj.Nome + ", "
                    + obj.Idade + " anos");
            }

        }
    }
}
