using System;
using System.Globalization;
using System.Collections.Generic;

namespace Cadastro_Empregados
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empregado> empregados = new List<Empregado>();

            Console.WriteLine("Quantos empregados você irá registrar? ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i<quantidade; i++ )
            {
                Console.WriteLine("Empregafo #" + (i+1) +":");
                int id = 0;
                do
                {
                    Console.Write("Id: ");
                    id = int.Parse(Console.ReadLine());
                    List<Empregado> resultado = new List<>();



                } while (); 

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());

                empregados.Add(new Empregado(id, nome, salario));
            }

            Console.WriteLine("insira o id do funcionario que voce deseja aumentar o salario: ");
            int id = int.Parse(Console.ReadLine());



        }
    }
}
