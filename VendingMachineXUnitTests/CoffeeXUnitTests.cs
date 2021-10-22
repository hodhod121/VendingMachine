using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace VendingMachine
{
    public class CoffeeXUnitTests
    {
        Coffee coffee = new("Coffee","28gr",35); 
        [Fact]
        public void Coffee_ReturnTrue()
        {
            int expected = 35;
            int actual = coffee.price;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CoffeeName_ReturnTrue()
        {
            string expected = "Coffee";
            string actual = coffee.name;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CoffeeWeight_ReturnTrue()
        {
            string expected = "28gr";
            string actual = coffee.weight;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CoffeeUse_ReturnTrue()
        {
            string expected = "Just drink the Coffee. Be careful, it is hot!";
            string actual = coffee.Use();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CoffeeExamine_ReturnTrue()
        {
            string expected = "Name: Coffee - Fresh Coffee - Price 35 kr";
            string actual = coffee.Examine();
            Assert.Equal(expected, actual);
        }
    }
}
