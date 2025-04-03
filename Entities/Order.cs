using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using ExercisePost.Entities;

namespace ExercisePost.Entities
{
    class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;

        public OrderStatus Status { get; set; }

        public Client Client { get; set; }

        List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

       
        public double Total()
        {
           
              double sum = 0.0;

            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }


        
       
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("ORDER SUMMARY");
            sb.AppendLine("Order Moment: " + Moment.ToString());
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client);

            foreach (var item in Items)
            {
                sb.AppendLine($"R$ {item.Price:F2}, Quantity: {item.Quantity}, SubTotal: R${item.SubTotal():F2}");
                sb.AppendLine(item.ToString());
            }
            sb.Append("Total Price: " + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();

        }

    }
}
