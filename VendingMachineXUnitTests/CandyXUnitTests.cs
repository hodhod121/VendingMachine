using System;
using Xunit;


namespace VendingMachine
{
     public class CandyXUnitTests
    {
        Candy candy = new();
        [Fact]
        public void Candy_ReturnTrue()
        {
            int expected = 32;
            int actual = candy.price();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CandyName_ReturnTrue()
        {            
            string expected = "Candy";
            string actual = candy.name;
            Assert.Equal(expected, actual);
        }
    }
}
