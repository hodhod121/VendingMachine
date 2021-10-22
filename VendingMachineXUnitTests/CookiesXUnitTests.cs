using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace VendingMachine
{
    public class CookiesXUnitTests
    {
        Cookies cookies = new("Cookie","80gr",78);
        [Fact]
        public void Cookies_ReturnTrue()
        {
            int expected = 78;
            int actual = cookies.price;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CookiesName_ReturnTrue()
        {
            string expected = "Cookie";
            string actual = cookies.name;
            Assert.Equal(expected, actual);
        }
    }
}
