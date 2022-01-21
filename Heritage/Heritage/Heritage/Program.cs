using System;
using System.Globalization;
using Heritage.Entities;

namespace Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double loanLimit, int number, string holder, double balance

            Console.Write("Quantas contas deseja cadastrar? ");
            int quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                Console.Write("Qual o nome do correntista?: ");
                string name = Console.ReadLine();

                Console.Write("Haverá deposito inicial? (s/n): ");
                char YesOrNo = char.Parse(Console.ReadLine().ToLower());

                double balance = 0.0;
                if (YesOrNo == 's')
                {
                    Console.Write("Digite o valor para deposito inicial: ");
                    balance = double.Parse(Console.ReadLine());

                }

                Console.Write("Conta Juridica? (s/n):");
                YesOrNo = char.Parse(Console.ReadLine().ToLower());

                if (YesOrNo == 's')
                {
                    Console.Write("Qual o limite para emprestimo? :");
                    double limitLoan = double.Parse(Console.ReadLine());

                    BussinessAccount bussinessAccount = new BussinessAccount(limitLoan, (i + 1), name, balance);
                }
                else
                {
                    Account account = new Account((i+1),name, balance);    
                }


            }



        }
    }
}
