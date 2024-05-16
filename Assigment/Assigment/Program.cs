using static System.Formats.Asn1.AsnWriter;
using Assigment;
using Xunit;
using FluentAssertions;

class Program {
    static void Main(string[] args)
    {
        Store store = new Store();

        Product product1 = new Product("Laptop", 999.99);
        Product product2 = new Product("Headphones", 49.99);

        store.AddProduct(product1);
        store.AddProduct(product2);

        Customer customer = new Customer("Alice");

        customer.AddToCart(product1);
        customer.AddToCart(product2);

        double totalAmount = customer.Checkout();

        // Applying discount
        double discountPercentage = 10;
        double discountedPrice = product1.ApplyDiscount(discountPercentage);
    }
}