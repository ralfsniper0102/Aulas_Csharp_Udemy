using AbstractMethods.Entitites;
using AbstractMethods.Entitites.Enum;
using System;
using System.Collections.Generic;

namespace AbstractMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Entre com a quantidade de formas: ");
            int quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine("Dados da forma #" + (i + 1) + ":");
                Console.Write("Retangulo ou Circulo (r/c)? ");
                char typeForm = char.Parse(Console.ReadLine().ToLower());

                if (typeForm == 'r')
                {
                    Console.Write("Cor (Preto/Azul/Vermelho)");
                    Color color = Enum.Parse<Color>(Console.ReadLine());
                    Console.WriteLine("Largura: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    double height = double.Parse(Console.ReadLine());

                    shapes.Add(new Rectangle(width, height, color));
                }
                else
                {

                }
            }
        }
    }
}

