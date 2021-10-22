using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace VendingMachine
{
    public class ColdFoodXUnitTests
    {
        ColdFood coldFood = new("Shrimp sallad","120gr",345);
        [Fact]
        public void ColdFood_ReturnTrue()
        {
            int expected = 345;
            int actual = coldFood.price;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ColdFoodName_ReturnTrue()
        {
            string expected = "Shrimp sallad";
            string actual = coldFood.name;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ColdFoodWeight_ReturnTrue()
        {
            string expected = "120gr";
            string actual = coldFood.weight;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ColdFoodUse_ReturnTrue()
        {
            string expected = "Just open and eat the Shrimp sallad!";
            string actual = coldFood.Use();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ColdFoodExamine_ReturnTrue()
        {
            string expected = "Name: Shrimp sallad - Fresh and tasty Shrimp sallad - Price 345 kr";
            string actual = coldFood.Examine();
            Assert.Equal(expected, actual);
        }
    }
}
