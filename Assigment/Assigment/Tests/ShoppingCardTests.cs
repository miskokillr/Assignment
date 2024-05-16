using Assigment;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace Assignment.Tests
{
    public class ShoppingCartTests
    {
        [Fact]
        public void AddProduct_ProductAddedToCart()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart();
            Product product = new Product("Laptop", 999.99);

            // Act
            cart.AddProduct(product);

            // Assert
            cart.Products.Should().ContainEquivalentOf(product);
        }

        [Fact]
        public void CalculateTotal_TotalCalculatedCorrectly()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart();
            Product product1 = new Product("Laptop", 999.99);
            Product product2 = new Product("Headphones", 49.99);

            cart.AddProduct(product1);
            cart.AddProduct(product2);

            // Act
            double total = cart.CalculateTotal();

            // Assert
            double expectedTotal = 1049.98;
            total.Should().Be(expectedTotal);
        }
    }
}
