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
                for (int column = zero; column < int.Parse(vlInput[1]); column = column + 1)
                {

                    matrix_main[line, column] = int.Parse(vlInputMatrix[column]);
                }
            }

            int vlInputScan = int.Parse(Console.ReadLine());
            for (int line = 0; line < int.Parse(vlInput[0]); line++)
            {

                int zero = 0;
                for (int column = zero; column < int.Parse(vlInput[1]); column = column + 1)
                {
                    if (matrix_main[line, column] == vlInputScan)
                    {

                        Console.WriteLine("Position: " + line + "," + column);

                        if (column != 0)
                        {
                            Console.WriteLine("Left: " + matrix_main[line, (column - 1)]);
                        }

                        if (column != int.Parse(vlInput[1]) - 1)
                        {
                            Console.WriteLine("Right: " + matrix_main[line, (column + 1)]);
                        }

                        if (line != 0)
                        {
                            Console.WriteLine("Up: " + matrix_main[(line - 1), column]);
                        }

                        if (line != int.Parse(vlInput[0]))
                        {
                            Console.WriteLine("Down: " + matrix_main[(line + 1), column]);
                        }
                    }
                }
            }
        }
    }
}

