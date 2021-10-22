using System;
using Xunit;


namespace VendingMachine
{
     public class CandyXUnitTests
    {
        Candy candy = new("Candy","100gr",32);
        [Fact]
        public void Candy_ReturnTrue()
        {
            int expected = 32;
            int actual = candy.price;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CandyName_ReturnTrue()
        {            
            string expected = "Candy";
            string actual = candy.name;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CandyWeight_ReturnTrue()
        {
            string expected = "100gr";
            string actual = candy.weight;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CandyUse_ReturnTrue()
        {
            string expected = "Just open and eat Candy!";
            string actual = candy.Use();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CandyExamine_ReturnTrue()
        {
            string expected = "Name: Candy - Very tasty Candy - Price 32 kr"; ;
            string actual = candy.Examine();
            Assert.Equal(expected, actual);
        }
    }
}
