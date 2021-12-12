using System;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int diagonal = int.Parse(Console.ReadLine());

            var mtx = new int[diagonal, diagonal];

            var vl = new int[diagonal];



            for (int count2 = 0; count2 < diagonal; count2++)
            {
                string[] vl_input = Console.ReadLine().Split();
                int countOut = 0;
                for (int count1 = countOut; count1 < diagonal; count1++)
                {
                    mtx[count1, count2] = int.Parse(vl_input[count1]);
                }
            }

            Console.Write("Diagonal: ");
            for (int count = 0; count < diagonal; count++)
            {
                Console.Write(mtx[count, count].ToString() + " ");
            }

            Console.WriteLine("");

            int countNegative = 0;
            for (int count2 = 0; count2 < diagonal; count2++)
            {

                int countOut = 0;
                for (int count1 = countOut; count1 < diagonal; count1++)
                {
                    if (mtx[count1, count2] < 0)
                    {
                        countNegative = countNegative + 1;
                    }
                }
            }
            Console.WriteLine("Quantidade de numeros negativos: " + countNegative.ToString());

            /*
            var m1 = new double[2, 4];

            Console.WriteLine(m1.Length); //// total de casas

            Console.WriteLine(m1.Rank);//// total de linhas

            Console.WriteLine(m1.GetLength(0)); //////// quantidade de linhas

            Console.WriteLine(m1.GetLength(1)); /////// quantidade de colunas
            */
        }
    }
}
