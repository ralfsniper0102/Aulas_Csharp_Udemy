using ProgramRequest.Entities;
using System;

namespace ProgramRequest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do Cliente: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de Nascimento (DD/MM/AAAA):");
            DateTime brithDate = DateTime.Parse(Console.ReadLine());

            Client cliente = new Client(name, email, brithDate);


        }
    }
}
