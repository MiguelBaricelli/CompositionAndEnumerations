using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisePost.Entities
{
     class OrderItem : Product
    {
        public int Quantity { get; set; }

       


        public OrderItem() { }

        public OrderItem(int quantity, double price) {

            this.Quantity = quantity;
            this.Price = price;
        }

        public double SubTotal()
        {
            
            return this.Quantity * this.Price;
        }
    }
}
