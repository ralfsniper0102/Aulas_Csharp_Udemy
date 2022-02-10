using System;

namespace InterfaceProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com os dados para o aluguel: ");
                Console.Write("Modelo do Carro: ");
                string modelCar = Console.ReadLine();
                Console.Write("Data de Entrada: (dd/mm/aaaa hh:mm): ");
                DateTime dateEntry = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de Saída: (dd/mm/aaaa hh:mm): ");
                DateTime dateExit = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Entre com valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.WriteLine("Entre com valor por dia: ");
                double valuePerDay = double.Parse(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
