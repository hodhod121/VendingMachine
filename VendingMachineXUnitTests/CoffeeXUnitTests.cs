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
    }
}
