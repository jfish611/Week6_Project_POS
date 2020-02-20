using System;
using Xunit;
using Point_Of_Sale;

namespace Week6_Project_POS
{
    public class Product_UnitTests
    {
        [Theory]
        [InlineData("ShackBurger", "Burgers", "Cheeseburger topped with lettuce, tomato, and shack sauce", 559, "ShackBurger")]

        public void PropertyTest_Name(string name, string cat, string desc, double price, string expected)
        {

            Product p = new Product(name, cat, desc, price);
            string nameResult = p.Name;
            Assert.Equal(expected, nameResult);
        }

        [Theory]
        [InlineData("ShackBurger", "Burgers", "Cheeseburger topped with lettuce, tomato, and shack sauce", 559, "Burgers")]

        public void PropertyTest_Category(string name, string cat, string desc, double price, string expected)
        {
            Product p = new Product(name, cat, desc, price);
            string Result = p.Category;
            Assert.Equal(expected, Result);
        }

        [Theory]
        [InlineData("ShackBurger", "Burgers", "Cheeseburger topped with lettuce, tomato, and shack sauce", 559, "Cheeseburger topped with lettuce, tomato, and shack sauce")]

        public void PropertyTest_Description(string name, string cat, string desc, double price, string expected)
        {
            Product p = new Product(name, cat, desc, price);
            string Result = p.Description;
            Assert.Equal(expected, Result);
        }

        [Theory]
        [InlineData("ShackBurger", "Burgers", "Cheeseburger topped with lettuce, tomato, and shack sauce", 5.59, 5.59)]

        public void PropertyTest_Price(string name, string cat, string desc, double price, double expected)
        {
            Product p = new Product(name, cat, desc, price);
            double Result = p.Price;
            Assert.Equal(expected, Result);
        }
    }
}
