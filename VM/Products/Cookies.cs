using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Cookies : BaseProduct
    {

        public Cookies(string name, string weight, int price)
        {
            this.name = name;
            this.weight = weight;
            this.price = price;
        }

        public override string Examine()
        {          
            return $"Name: {name} - New made {name} - Price {price} kr";
        }
        public override string Use()
        {
            return $"Just open and eat the {name}!";
        }
    }
}
