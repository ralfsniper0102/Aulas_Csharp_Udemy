using System;
using System.Globalization;
using WorkProgram_test1.Entities.Enum;
using WorkProgram_test1.Entities;

namespace WorkProgram_test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o nome do departamento: ");
            string departamentName = Console.ReadLine();

            Console.WriteLine("Entre com os dados do trabalhador:");
            Console.Write("Nome: ");
            string nameWorker = Console.ReadLine();

            Console.Write("Level (Junior/Mid_Level/Senior): ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salarial: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(departamentName);

            Worker worker = new Worker(nameWorker, workerLevel, baseSalary, dept);



            Console.Write("Quantos contratos para esse trabalhador? ");
            int quantityContracts = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantityContracts; i++)
            {
                Console.WriteLine("Entre com os dados do contrato #" + (i + 1));
                Console.Write("Data (DD/MM/AAAA): ");
                DateTime dateContract = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor por Hora: ");
                double valueHora = double.Parse(Console.ReadLine());

                Console.Write("Duração (horas): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(dateContract, valueHora, hours);

                worker.AddContract(contract);
            }

            Console.Write("Entre com o mes e o ano para calular a renda (MM/AAAA): ");
            string MonthAndYears = Console.ReadLine();

            int month = int.Parse(MonthAndYears.Substring(0,2));
            int year = int.Parse(MonthAndYears.Substring(3));

            Console.WriteLine("Nome: " + worker.Nome);
            Console.WriteLine("Departamento: " + worker.Departament.Name);
            Console.WriteLine("Renda de " + MonthAndYears + ": " + worker.Income(year,month).ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}
