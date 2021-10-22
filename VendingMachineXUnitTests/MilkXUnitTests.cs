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
    }
}
