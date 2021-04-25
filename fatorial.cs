using System;
using System.Globalization;

namespace ConsoleApp3
{
    class Program
        
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual valor voce quer inserir?");
            int valor = int.Parse(Console.ReadLine());
            int fat = 1;
            for(int i=1; i<=valor;i++)
            {
                fat = fat * i;
            }
            Console.WriteLine(fat);
           
        }


    }
}
