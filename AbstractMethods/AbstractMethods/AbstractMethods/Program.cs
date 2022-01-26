using AbstractMethods.Entitites;
using AbstractMethods.Entitites.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;

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
                Color color;
                switch (typeForm)
                {
                    case 'r':
                        Console.Write("Cor (Preto/Azul/Vermelho): ");
                        color = Enum.Parse<Color>(Console.ReadLine());
                        Console.Write("Largura: ");
                        double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        Console.Write("Altura: ");
                        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        shapes.Add(new Rectangle(width, height, color));
                        break;

                    case 'c':
                        Console.Write("Cor (Preto/Azul/Vermelho): ");
                        color = Enum.Parse<Color>(Console.ReadLine());
                        Console.Write("Raio: ");
                        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        shapes.Add(new Circle(radius, color));
                        break;

                    default:
                        break;


                }
                    
                
                    
               
            }

            Console.WriteLine("Área das Formas: ");

            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2",CultureInfo.InvariantCulture)) ;
            }
        }
    }
}

