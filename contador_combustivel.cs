using System;
using System.Globalization;

namespace ConsoleApp3
{
    class Program
        
    {
        static void Main(string[] args)
        {
            int alcool = 0, gasolina = 0, diesel = 0;
            int numero = 0;

            while (numero != 4)
            {
                Console.WriteLine("1 - Alcool");
                Console.WriteLine("2 - Gasolina");
                Console.WriteLine("3 - Diesel");
                Console.WriteLine("4 - Sair");
                Console.Write("Digite o numero do combustivel de sua preferencia: ");
                numero = int.Parse(Console.ReadLine());

                if (numero < 1 || numero > 4)
                {
                    Console.WriteLine("Numero invalido");
                }
                else if (numero == 1)
                {
                    alcool = alcool + 1;
                }
                else if (numero == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (numero == 3)
                {
                    diesel = diesel + 1;
                }
            }
            Console.WriteLine("Muito Obrigado");
            Console.WriteLine("Alcool " + alcool);
            Console.WriteLine("Gasolina " + gasolina);
            Console.WriteLine("Diesel " + diesel);

        }
    }
}
