using System;
using System.Globalization;
using WorkerContractProgram.Entities.Enums;
using WorkerContractProgram.Entities; 

namespace WorkerContractProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o nome do Departamento: ");
            string nameDepartament = Console.ReadLine();

            Console.WriteLine("Entre com os dados do trabalhador: ");
            Console.Write("Nome: ");
            string nameWorker = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel levelWorker = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Salario base: ");
            double salaryBase = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Departament dept = new Departament(nameDepartament);
            Worker worker = new Worker(nameWorker, levelWorker, salaryBase, dept);

            Console.Write("Quantos contratos para este trabalhador: ");
            int quantityContract = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantityContract; i++)
            {
                Console.WriteLine("Contrato " + (i + 1) + " Entre com a data: ");
                Console.Write("Data (DD/MM/AAAA): ");
                DateTime dateContract = DateTime.Parse(Console.ReadLine());
                
                Console.Write("Valor por horas: ");
                double valueHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.Write("Duração (hours): ");
                int duration = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(dateContract, valueHour, duration);
                worker.AddContract(contract);
            }

            Console.WriteLine("Entre com o mês e o ano para calcular a renda(MM/AAAA): ");
            string monthAndYears = Console.ReadLine();
            int month = int.Parse(monthAndYears.Substring(0,2));
            int years = int.Parse(monthAndYears.Substring(3));
            Console.WriteLine("Nome: " + worker.Name);
            Console.WriteLine("Departamento: " + worker.Departament.Name);
            Console.WriteLine("Renda de " + monthAndYears + ": " + worker.Income(years,month));





        }
    }
}
