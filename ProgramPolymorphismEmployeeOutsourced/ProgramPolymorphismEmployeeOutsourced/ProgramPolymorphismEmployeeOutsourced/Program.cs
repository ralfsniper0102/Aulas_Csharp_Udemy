using System;
using System.Collections.Generic;
using ProgramPolymorphism.Entities;
using System.Globalization;

namespace ProgramPolymorphism
{ 
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Entre com o número de empregados: ");
            int quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine("Dados do Empregado #" + (i + 1));
                Console.Write("Tercerizado? (s/n): ");
                char yesOrNo = char.Parse((Console.ReadLine().ToLower()));
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Horas: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuePorHours = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (yesOrNo == 's')
                {
                    Console.Write("Taxa de Adição: ");
                    double additionalCharger = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourceEmplyee(name, hours, valuePorHours, additionalCharger));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePorHours));

                }
                Console.WriteLine("");

            }
            Console.WriteLine("");
            Console.WriteLine("Pagamentos:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Name
                    + " - $ "
                    + employee.Payment().ToString("F2",CultureInfo.InvariantCulture)
                    );
            }
        }
    }
}
