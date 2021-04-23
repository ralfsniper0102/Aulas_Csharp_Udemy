using System;
using System.Globalization;

namespace ConsoleApp3
{
    class Program
        
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite horários valores:");

            string[] vetor = Console.ReadLine().Split(' ');
            
            
            int horario1 = int.Parse(vetor[0]);

            
            int horario2 = int.Parse(vetor[1]);

            int total_horas = 0;

            if(horario1 > horario2)
            {
                total_horas = 24 - horario1 + horario2;
                Console.WriteLine("O jogo durou " + total_horas + " Horas");
            }
            else if (horario1 < horario2)
            {
                total_horas =  horario2 - horario1;
                Console.WriteLine("O jogo durou " + total_horas + " Horas");
            }
            else
            {
                Console.WriteLine("O jogo durou 24 Horas");
            }

        }
    }
}
