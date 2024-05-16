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
    public class StoreTests
    {
        [Fact]
        public void AddProduct_ProductAddedToStore()
        {
            // Arrange
            Store store = new Store();
            Product product = new Product("Laptop", 999.99);

            // Act
            store.AddProduct(product);

            // Assert
            store.AvailableProducts.Should().ContainEquivalentOf(product);
        }
    }
}
