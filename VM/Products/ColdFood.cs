using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class ColdFood : BaseProduct
    {
        public ColdFood(string name, string weight, int price)
        {
            this.name = name;
            this.weight = weight;
            this.price = price;
        }

        public override string Examine()
        {         
            return $"Name: {name} - Fresh and tasty {name} - Price {price} kr";
        }
        public override string Use()
        {
            return $"Just open and eat the {name}!";
        }
    }
}
