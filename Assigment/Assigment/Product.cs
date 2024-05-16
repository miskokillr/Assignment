using Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment
{
    public interface IDiscountable
    {
        double ApplyDiscount(double price);
    }

    public class Product : Abs, IDiscountable
    {
        public override void Description()
        {
            Console.WriteLine("The product is fresh");
        }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public double ApplyDiscount(double discountPercentage)
        {
             Price = Price - Price * discountPercentage / 100;
            Console.WriteLine($"Discount applied to {Name}: {Price:C}");
            return Price;
        }

    }
    public static class IntExtensions
    {
        public static double priceConvertInt(this int price)
        {
            return Convert.ToInt32(price);
        }

    }
}
