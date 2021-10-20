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
        FreshFruit freshFruit = new();
        [Fact]
        public void FreshFruit_ReturnTrue()
        {
            int expected = 42;
            int actual = freshFruit.price();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FreshFruitName_ReturnTrue()
        {
            string expected = "FreshFruit";
            string actual = freshFruit.name;
            Assert.Equal(expected, actual);
        }
    }
}
