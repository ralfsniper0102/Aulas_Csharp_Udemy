using EnumProgram.Entities;
using System;
using EnumProgram.Entities.Enums;

namespace EnumProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PagamentoPendente
                

            };

            Console.WriteLine(order);

            string txt = OrderStatus.Entregue.ToString();
            Console.WriteLine(txt);

            OrderStatus orderStatus = Enum.Parse<OrderStatus>("Entregue");
            Console.WriteLine(orderStatus);
        }
    }
}
