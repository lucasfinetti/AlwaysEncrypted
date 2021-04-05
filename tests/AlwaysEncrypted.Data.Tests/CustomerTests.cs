using AlwaysEncrypted.Data.Models;
using AlwaysEncrypted.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlwaysEncrypted.Data.Tests
{
    public class CustomerTests
    {
        [Fact]
        public void Customer_CreateCustomer_ShouldCanCreate()
        {
            // Arrange
            var customerRepMock = new Moq.Mock<ICustomerRep>();
            var customer = new Customer()
            {
                FirstName = "",
                LastName = ""
            };

            // Act
            customerRepMock.Object.Add(customer);

            // Assert
        }
    }
}
