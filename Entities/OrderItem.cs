using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisePost.Entities
{
     class OrderItem
    {
        public int Quantity { get; set; }

        public Product Product { get; set; }


        

        public OrderItem() { }

        public OrderItem(int quantity, Product price) {

            this.Quantity = quantity;
            this.Product = price;
        }

        public double SubTotal()
        {
            
            return this.Quantity * this.Product.Price;
        }
    }
}
