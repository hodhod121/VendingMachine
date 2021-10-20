using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace VendingMachine
{
    public class VendingMachineXUnitTest
    {
        VendingMachine vendingMachine = new();
        [Fact]
        public void VendingMachine_ReturnTrue()
        {
           
            Assert.True(true);
        }
    }
}
