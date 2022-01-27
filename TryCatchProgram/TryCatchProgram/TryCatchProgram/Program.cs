using System;

namespace TryCatchProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

          
            try
            {
                Console.WriteLine("ola digite um numero");
                double a = int.Parse(Console.ReadLine());

                Console.WriteLine(a);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("erro " + ex.Message);
            }
        }
    }
}
