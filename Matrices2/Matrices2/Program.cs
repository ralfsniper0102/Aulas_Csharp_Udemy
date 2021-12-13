using System;

namespace Matrices2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 2 valores (Ex.: 3 4): ");

            var vlInput = Console.ReadLine().Split();

            var matrix_main = new int[(int.Parse(vlInput[0])), (int.Parse(vlInput[1]))];

            
            for (int line = 0; line < int.Parse(vlInput[0]); line++)
            {
                var vlInputMatrix = Console.ReadLine().Split();
                int zero = 0;
                for (int column = zero; column < int.Parse(vlInput[1]); column = column +1)
                {
                    
                    matrix_main[line, column] = int.Parse(vlInputMatrix[column]);
                }
            }
        }
    }
}

