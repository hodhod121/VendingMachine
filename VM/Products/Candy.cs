using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Candy : BaseProduct
    {

        public Candy(string name, string weight, int price)
        {
            this.name = name;
            this.weight = weight;
            this.price = price;
        }

        public override string Examine()
        {         
            return $"Name: {name} - Very tasty {name} - Price {price} kr";
        }
        public override string Use()
        {
            return $"Just open and eat {name}!";
        }
    }
}
