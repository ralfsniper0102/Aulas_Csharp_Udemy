using System;

namespace Reuse
{
    class Program
    {
        static void Main(string[] args)
        {

            var printService = new PrintService<int>(); ///// modificated for reuse

            Console.WriteLine("Quantos valores voce deseja inserir? ");
            int quantity = int.Parse(Console.ReadLine());

            for (int count = 0; count < quantity; count++)
            {
                printService.addValue(int.Parse(Console.ReadLine())); 
            }

            printService.Print();
            Console.WriteLine("");
            Console.WriteLine("First: " + printService.First().ToString());



        }
    }
}
