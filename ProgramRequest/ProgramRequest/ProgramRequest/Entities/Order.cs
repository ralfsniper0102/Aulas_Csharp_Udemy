using ProgramRequest.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace ProgramRequest.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> orderItems { get; set; } = new List<OrderItem>();
        public Order()
        {

        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            orderItems.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            orderItems.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in orderItems)
            {
                sum = item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Momento do Pedido: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Estatos do pedido:");
            sb.AppendLine(Status.ToString());
            sb.Append("Cliente: ");
            sb.AppendLine(Client.Name
                + "("
                + Client.BirthDate
                + ")"
                + " - "
                + Client.Email
                );
            sb.AppendLine("Itens da Ordem: ");

            foreach (OrderItem item in orderItems)
            {
                sb.AppendLine(item.Product.Name
                    + ", "
                    + item.Product.Price.ToString("F2", CultureInfo.InvariantCulture)
                    + ", Quantidade: "
                    + item.Quantity
                    + ", Subtotal:  "
                    + item.SubTotal()
                    + "Preço Total: "
                    + Total().ToString("F2",CultureInfo.InvariantCulture)
                    ) ;

            }
            



            return sb.ToString();
        }
    }

}
