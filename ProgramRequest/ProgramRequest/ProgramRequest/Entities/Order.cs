using ProgramRequest.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            foreach(OrderItem item in orderItems)
            {
                sum = item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();



            return sb.ToString();
        }
    }

}
