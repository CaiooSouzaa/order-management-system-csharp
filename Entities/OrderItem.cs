using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios.Ex10
{
    public class OrderItem
    {
        public double Price { get; set; }
        public int Quantity { get; set; }
        
        public Product Product { get; set; }

        public OrderItem(){}

        public OrderItem(double price, int quantity, Product product)
        {

            Price = price;
            Quantity = quantity;
            Product = product;
            
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}