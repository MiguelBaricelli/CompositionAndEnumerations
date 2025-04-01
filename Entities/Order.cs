using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisePost.Entities
{
    class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;

        public OrderStatus Status { get; set; }

        public double FinalPrice { get; set; }

        List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
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
            OrderItem orderItem = new OrderItem();
            double subtotal = orderItem.SubTotal();

            foreach (OrderItem item in Items)
            {
             
                subtotal += FinalPrice;
            }
            return FinalPrice;
        }


        Client client = new Client();
       
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("ORDER SUMMARY");
            sb.Append("Order Moment: " + Moment.ToString());
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + client.Name + " " +client.BirthDate + " " + client.Email);

            foreach (var item in Items)
            {
                sb.AppendLine($"Name: {item.Product.Name}, R${item.Product.Price:F2}, Quantity: {item.Quantity}, SubTotal: R${item.SubTotal():F2}");
            }
            sb.Append("Total Price" + Total());
            return sb.ToString();

        }

    }
}
