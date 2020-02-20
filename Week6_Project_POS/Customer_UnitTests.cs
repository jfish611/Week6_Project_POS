using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Point_Of_Sale;


namespace Week6_Project_POS_Tests
{
    public class Customer_UnitTests
    {
        [Theory]
        [InlineData("Lemondade", "Drink", "Refreshing drink", 1.50, 2)]

        public void Customer_AddToCart_ItemIsAdded(string name, string category, string desc, double price, int quant)
        {
            Customer c = new Customer();
            Product p = new Product(name, category, desc, price);
            c.AddToCart(p, quant);
            Assert.NotEmpty(c.Cart);
            Assert.Equal(c.Cart[p], quant);
        }
    }


}

