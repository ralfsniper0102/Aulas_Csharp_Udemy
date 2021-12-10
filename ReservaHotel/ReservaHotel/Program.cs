using System;

namespace ReservaHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos você deseja reservar? ");
            int quantidade = int.Parse(Console.ReadLine());

            Reserva[] x = new Reserva[11]; 
            
            for(int i = 1; i <= quantidade; i++ )
            {
                Console.WriteLine("Reserva #" + (i) + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
             
                x[quarto] = new Reserva(nome, email);
                Console.WriteLine("");
            }

            Console.WriteLine("Quartos Reservados: ");
            for (int i = 1; i<=10; i++)
            {
                if (x[i] != null)
                {
                   Console.WriteLine(i + ": " + x[i]);
                   
                    
                }
            }

        }
    }
}
