using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace VendingMachine
{
    public class ChipsXUnitTests
    {
        Chips chips = new();
        
        [Fact]
        public void Chips_ReturnTrue()
        {
            int expected = 47;
            int actual = chips.price();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ChipsName_ReturnTrue()
        {
            string expected = "Chips";
            string actual = chips.name;
            Assert.Equal(expected, actual);
        }

    }
}
