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
            int id = 0;
            Console.WriteLine("Quantos empregados você irá registrar? ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i<quantidade; i++ )
            {
                Console.WriteLine("Empregado #" + (i+1) +":");
                
                do
                {
                    Console.Write("Id: ");
                    id = int.Parse(Console.ReadLine());

                    Empregado resultado = empregados.Find(x => x.Id == id);
                    
                    if(resultado.Id != 0)
                    {
                        Console.WriteLine("id cadastrado anteriormente");
                        id = 0;
                    }
                                      
                } while (id == 0); 

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                empregados.Add(new Empregado(id, nome, salario));
            }

            Console.WriteLine("insira o id do funcionario que voce deseja aumentar o salario: ");
            id = int.Parse(Console.ReadLine());

            do
            {
                Empregado resultado = empregados.Find(x => x.Id == id);
                if (resultado.Id != id )
                {
                    Console.WriteLine("usuário não existente");
                    id = 0;
                }
                else
                {
                    Console.WriteLine("Entre com a porcentagem a ser adicionada: ");
                    double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    int posicao = empregados.FindIndex(x => x.Id == id);
                    empregados[posicao].Aumento(porcentagem);
                }

            } while (id == 0);


            foreach (Empregado obj in empregados)
            {
                Console.WriteLine(obj.Id + ", " + obj.Nome + ", " + obj.Salario);
            }

        }
    }
}
