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
        [Fact]
        public void CookiesWeight_ReturnTrue()
        {
            string expected = "80gr";
            string actual = cookies.weight;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CookiesUse_ReturnTrue()
        {
            string expected = "Just open and eat the Cookie!";
            string actual = cookies.Use();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CookiesExamine_ReturnTrue()
        {
            string expected = "Name: Cookie - New made Cookie - Price 78 kr";
            string actual = cookies.Examine();
            Assert.Equal(expected, actual);
        }
    }
}
