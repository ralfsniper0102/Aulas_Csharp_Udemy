using System;

namespace DepositoESaque
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre com o número da Conta: ");
            int n_conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o título da conta: ");
            string nome = Console.ReadLine();

            Usuario x = new Usuario(n_conta, nome);

            Console.Write("Haverá depósito inicial? (s/n) ?");
            char simNao = char.Parse(Console.ReadLine());

            if (simNao == 's' || simNao == 'S')
            {
                Console.Write("Entre com o valor de Depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine());
                x.Depositar(double.Parse(Console.ReadLine()));


            }
        }
    }
}
