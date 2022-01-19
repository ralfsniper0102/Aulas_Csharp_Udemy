using ProgramRequest.Entities;
using ProgramRequest.Entities.Enum;
using System;

namespace ProgramRequest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do Cliente: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de Nascimento (DD/MM/AAAA):");
            DateTime brithDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, brithDate);

            Console.WriteLine("Entre com os dados dos pedidos ():");
            string status = Console.ReadLine();

            Console.WriteLine("Quantos itens estarão nesse pedido? ");
            int itens = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, Enum.Parse<OrderStatus>(status), client);

            for (int i = 0; i < itens; i++)
            {
                Console.WriteLine("Entre com os dados do item # " + (i + 1) + ": ");
                Console.Write("Nome do produto: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double priceProduct = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantidade: ");
                int quantityProduct = int.Parse(Console.ReadLine());

                Product product = new Product(name, priceProduct);

                OrderItem orderItem = new OrderItem(quantityProduct, priceProduct, product);

                order.AddItem(orderItem);

            }
            Console.WriteLine("Resumo do Pedido");

            Console.WriteLine(order);

        }
    }
}
