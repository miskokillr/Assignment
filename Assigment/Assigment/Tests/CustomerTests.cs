using Assigment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace Assignment.Tests
{

    public class CustomerTests
    {

        [Fact]
        public void AddToCart_ProductAddedToCart()
        {
            // Arrange
            Customer customer = new Customer("Alice");
            Product product = new Product("Laptop", 999.99);

            // Act
            customer.AddToCart(product);

            // Assert
            customer.Cart.Products.Should().ContainEquivalentOf(product);
        }

        [Fact]
        public void Checkout_TotalAmountToPayCorrect()
        {
            // Arrange
            Customer customer = new Customer("Alice");
            Product product1 = new Product("Laptop", 999.99);
            Product product2 = new Product("Headphones", 49.99);

            customer.AddToCart(product1);
            customer.AddToCart(product2);

            // Act
            double totalAmount = customer.Checkout();

            // Assert
            double expectedTotalAmount = 1049.98;
            totalAmount.Should().Be(expectedTotalAmount);

        }
    }
}
