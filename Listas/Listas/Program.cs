using System;
using System.Globalization;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> lista = new List<Pessoa>();


            Console.WriteLine("Quantas pessoas deseja cadastrar? ");
            int quantidade = int.Parse(Console.ReadLine());

            for(int i = 0; i<quantidade ; i++)
            {
                Console.WriteLine("Digite o Nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a Idade: ");
                int idade = int.Parse(Console.ReadLine());

                lista.Add(new Pessoa(nome, idade));
            }

            foreach (Pessoa obj in lista)
            {
                Console.WriteLine(obj.Nome + ", " + obj.Idade);
            }
            
       
        }
    }
}
