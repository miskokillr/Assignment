using Assigment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace Assignment
{
    public class ProductTest
    {
        [Fact]
        public void ApplyDiscount_DiscountAppliedCorrectly()
        {
            // Arrange
            Product product = new Product("Laptop", 999.99);
            double discountPercentage = 10;

            // Act
            double discountedPrice = product.ApplyDiscount(discountPercentage);

            // Assert
            double expectedDiscountedPrice = 899.99;
            discountedPrice.Should().Be(expectedDiscountedPrice);
        }
    }
}


