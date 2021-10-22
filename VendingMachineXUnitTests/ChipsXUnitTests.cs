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
        Chips chips = new("Chips","90gr",47);
        
        [Fact]
        public void Chips_ReturnTrue()
        {
            int expected = 47;
            int actual = chips.price;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ChipsName_ReturnTrue()
        {
            string expected = "Chips";
            string actual = chips.name;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ChipsWeight_ReturnTrue()
        {
            string expected = "90gr";
            string actual = chips.weight;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ChipsUse_ReturnTrue()
        {
            string expected = "Eat Chips just like that or with yoghurt!";
            string actual = chips.Use();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ChipsExamine_ReturnTrue()
        {
            string expected = "Name: Chips - The best Chips - Price 47 kr";
            string actual = chips.Examine();
            Assert.Equal(expected, actual);
        }

    }
}
