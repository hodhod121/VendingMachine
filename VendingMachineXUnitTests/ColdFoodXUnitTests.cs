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
        ColdFood coldFood = new();
        [Fact]
        public void ColdFood_ReturnTrue()
        {
            int expected = 345;
            int actual = coldFood.price();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ColdFoodName_ReturnTrue()
        {
            string expected = "ColdFood";
            string actual = coldFood.name;
            Assert.Equal(expected, actual);
        }
    }
}
