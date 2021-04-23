using System;
using System.Globalization;

namespace ConsoleApp3
{
    class Program
        
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CODIGO   |       ESPECIFICAÇÃO          |        PREÇO");
            Console.WriteLine("1        |       Cachorro Quente        |        R$ 4.00");
            Console.WriteLine("2        |       X-Salada               |        R$ 4.50");
            Console.WriteLine("3        |       X-Bacon                |        R$ 5.00");
            Console.WriteLine("4        |       Torrada simples        |        R$ 2.00");
            Console.WriteLine("5        |       Refrigerante           |        R$ 1.50");

            Console.WriteLine("Digite o Código e a Quantidade:");
            string[] vs = Console.ReadLine().Split(' ');
            int c = int.Parse(vs[0]);
            int q = int.Parse(vs[1]);
            double valor = 0;
            
            if (c==1)
            {
                valor = 4.00;
            }
            else if (c == 2)
            {
                valor = 4.50;
            }
            else if (c == 3)
            {
                valor = 5.00;
            }
            else if (c == 4)
            {
                valor = 2.00;
            }
            else
            {
                valor = 1.50;
            }

            double valor_total = valor * q;

            Console.WriteLine("Total: R$ " + valor_total.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
