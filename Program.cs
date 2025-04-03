using ExercisePost.Entities;
using System;
using System.Globalization;


namespace ExercisePost
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            

            Console.WriteLine("Name: ");
            string nameClient = Console.ReadLine().Trim();
            Console.WriteLine("Email: ");
            string emailClient = Console.ReadLine().Trim();
            Console.WriteLine("Birth Date (DD/MM/YYYY)");
            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Client client = new(nameClient,emailClient,birthDate);
            

            Console.WriteLine("Enter order data: ");
            OrderStatus status = new OrderStatus();

            /*
             Check which stage you are in the Status process
             */
            Console.WriteLine("Status: ");
            status = (OrderStatus)int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("Status: " + status.ToString());
            Console.WriteLine("How many Items to this order: ");

            int choice = int.Parse(Console.ReadLine());


            for (int i = 0; i < choice; i++)
            {
                
                Console.WriteLine($"Enter #{i + 1} item data: ");
                Console.WriteLine("Product name: ");
                string productName = Console.ReadLine();
                Console.WriteLine("Product price: ");
                double Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Quatity: ");
                int Quantity = int.Parse(Console.ReadLine());

                Product product = new(productName, Price);
                OrderItem orderItem = new(Quantity, Price);

               order.AddItem(orderItem);
            }

            Console.WriteLine(order);

        }
    }
}
