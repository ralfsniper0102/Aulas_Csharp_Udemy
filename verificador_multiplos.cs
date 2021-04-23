using System;
using System.Globalization;

namespace ConsoleApp3
{
    class Program
        
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores:");

            string[] vetor = Console.ReadLine().Split(' ');
            
            
            int valor1 = int.Parse(vetor[0]);

            
            int valor2 = int.Parse(vetor[1]);

            if(valor1 > valor2)
            {
                if(valor1 % valor2 ==0)
                {
                    Console.WriteLine("São múltiplos");
                }
                else
                {
                    Console.WriteLine("Não são múltiplos");
                }
            }
            else if (valor1 < valor2)
            {
                if (valor2 % valor1 == 0)
                {
                    Console.WriteLine("São múltiplos");
                }
                else
                {
                    Console.WriteLine("Não são múltiplos");
                }
            }
            else
            {
                Console.WriteLine("Não são multiplos");
            }




        }
    }
}
