using ExercisePost.Entities;
using System;
using System.Globalization;

namespace ExercisePost
{
    class Program
    {
        public static void Main(string[] args)
        {
            Client client = new Client();
            Order order = new Order();
            List<OrderItem> orderItems = new List<OrderItem>();

            Console.WriteLine("Name: ");
            client.Name = Console.ReadLine();
            Console.WriteLine("Email: ");
            client.Email = Console.ReadLine();
            Console.WriteLine("Birth Date (DD/MM/YYYY)");
            client.BirthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Enter order data: ");
            OrderStatus status = new OrderStatus();

            /*
             Check which stage you are in the Status process
             */
            Console.WriteLine("Status: ");
            status = (OrderStatus)int.Parse(Console.ReadLine());
            

            Console.WriteLine("Status: " + status.ToString());
            Console.WriteLine("How many Items to this order: ");

            int choice = int.Parse(Console.ReadLine());


            for (int i = 1; i < choice; i++)
            {
                
                Console.WriteLine($"Enter #{i} item data: ");
                Console.WriteLine("Product name: ");
                string Name = Console.ReadLine();
                Console.WriteLine("Product price: ");
                double Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Quatity: ");
                int Quantity = int.Parse(Console.ReadLine());

                Product product = new Product(Name, Price);
                OrderItem item = new OrderItem(Quantity, product);

                orderItems.Add(item);
            }

            order.ToString();


        }
    }
}
