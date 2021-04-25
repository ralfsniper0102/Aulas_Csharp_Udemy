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
            int dentro =0, fora = 0;
            for(int c=1; c<=q; c++)
            {
                Console.WriteLine("Digite o valor: ");
                int v = int.Parse(Console.ReadLine());
                if (v >=0 && v <= 25)
                {
                    dentro = dentro + 1;
                }
                else
                {
                    fora = fora + 1;
                }
            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }


    }
}
