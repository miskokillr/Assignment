using Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment
{
    public class Customer:Abs
    {
        public override void Description()
        {
            Console.WriteLine("The customer is always right");
        }
        public ShoppingCart Cart { get; set; }

        public Customer(string name)
        {
            Name = name;
            Cart = new ShoppingCart();
        }

        public void AddToCart(Product product)
        {
            Cart.AddProduct(product);
        }

        public double Checkout()
        {
            double total = Cart.CalculateTotal();
            Console.WriteLine($"Total amount to pay: {total:C}");
            return total;
        }
    }
}
