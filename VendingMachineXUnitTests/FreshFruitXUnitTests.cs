using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace VendingMachine
{
    public class FreshFruitXUnitTests
    {
        FreshFruit freshFruit = new("Apple","200gr",42);
        [Fact]
        public void FreshFruit_ReturnTrue()
        {
            int expected = 42;
            int actual = freshFruit.price;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FreshFruitName_ReturnTrue()
        {
            string expected = "Apple";
            string actual = freshFruit.name;
            Assert.Equal(expected, actual);
        }
    }
}
