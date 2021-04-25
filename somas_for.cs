using System;
using System.Globalization;

namespace ConsoleApp3
{
    class Program
        
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos valor voce quer inserir?");
            int q = int.Parse(Console.ReadLine());
            int c=1, t=0;
            for(int i=1 ; c<=q ; c++)
            {
                Console.Write("Valor #" +i+": ");
                t = t + int.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine("Valor Total: " + t);        
        }
    }
}
