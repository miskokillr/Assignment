using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment
{
    public class Store
    {
        public List<Product> AvailableProducts { get; set; }

        public Store()
        {
            AvailableProducts = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            AvailableProducts.Add(product);
            Console.WriteLine($"{product.Name} added to the store.");
        }
    }
}
