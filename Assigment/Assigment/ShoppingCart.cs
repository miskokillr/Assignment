using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Assigment
{
    public class ShoppingCart
    {
        public List<Product> Products { get; set; }

        public ShoppingCart()
        {
            Products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
            Console.WriteLine($"{product.Name} added to the shopping cart.");
        }

        public double CalculateTotal()
        {

          
            List<Product> prod = Products;

            double total = prod.Sum(item => item.Price);

            return total;
            
        }
    }
}
