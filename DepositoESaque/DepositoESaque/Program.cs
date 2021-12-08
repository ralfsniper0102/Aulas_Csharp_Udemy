using System;
using System.Globalization;

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

            Console.Write("Haverá depósito inicial? (s/n)? ");
            char simNao = char.Parse(Console.ReadLine());

            double deposito;
            
            if (Char.ToLower(simNao) == 's')
            {
                Console.Write("Entre com o valor de Depósito inicial: ");
                deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                x.Depositar(deposito);
            }

            Console.WriteLine("");
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(x);

            Console.Write("Entre com um valor para depósito: ");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Depositar(deposito);
            Console.WriteLine("");

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(x);

            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x.Saque(saque);
            Console.WriteLine("");



            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(x);





        }
    }
}
