using System;
using System.Globalization;
using ProgramDepositWithdraw.Entities.Exceptions;
using ProgramDepositWithdraw.Entities;

namespace ProgramDepositWithdraw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Entre com os dados da conta:");
                Console.Write("Numero: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Titular: ");
                string holder = Console.ReadLine();

                Console.Write("Saldo Incial: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Limite para Saque: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.Write("Entre com um valor para saque: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.Withdraw(withdraw);

                Console.WriteLine("Novo Saldo: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
