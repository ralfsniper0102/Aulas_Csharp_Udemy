using System;
using System.Globalization;

namespace WorkerContractProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o nome do Departamento:");
            string nameDepartament = Console.ReadLine();

            Console.WriteLine("Entre com os dados do trabalhador: ");
            Console.Write("Nome: ");
            string nameWorker = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior: ");
            string levelWorker = Console.ReadLine();

            Console.Write("Salario base: ");
            double salaryBase = double.Parse(Console.ReadLine());

            Console.Write("Quantos contratos para este trabalhador: ");
            int quantityContract = int.Parse(Console.ReadLine());

            for ( int i = 0; i<quantityContract; i++)
            {
                Console.WriteLine("Contrato " + (i+1) + "Entre com a data: ");
                Console.Write("Data (DD/MM/YYYY): ");
                

            }

        }
    }
}
