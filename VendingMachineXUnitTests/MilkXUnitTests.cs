using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace VendingMachine
{
    public class MilkXUnitTests
    {
        Milk milk = new("Milk","200gr",39);
        [Fact]
        public void Milk_ReturnTrue()
        {
            int expected = 39;
            int actual = milk.price;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void MilkName_ReturnTrue()
        {
            string expected = "Milk";
            string actual = milk.name;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void MilkWeight_ReturnTrue()
        {
            string expected = "200gr";
            string actual = milk.weight;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void MilkUse_ReturnTrue()
        {
            string expected = "Just open and drink the Milk!";
            string actual = milk.Use();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void MilkExamine_ReturnTrue()
        {
            string expected = "Name: Milk - Very fresh and tasty Milk - Price 39 kr";
            string actual = milk.Examine();
            Assert.Equal(expected, actual);
        }
    }
}
