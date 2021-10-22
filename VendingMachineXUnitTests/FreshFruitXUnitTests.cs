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
        FreshFruit freshFruit = new("Fresh fruit","200gr",42);
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
            string expected = "Fresh fruit";
            string actual = freshFruit.name;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FreshFruitWeight_ReturnTrue()
        {
            string expected = "200gr";
            string actual = freshFruit.weight;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FreshFruitUse_ReturnTrue()
        {
            string expected = "Just open and eat the Fresh fruit!";
            string actual = freshFruit.Use();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FreshFruitExamine_ReturnTrue()
        {
            string expected = "Name: Fresh fruit - Fresh Fresh fruit - Price 42 kr";
            string actual = freshFruit.Examine();
            Assert.Equal(expected, actual);
        }
    }
}
