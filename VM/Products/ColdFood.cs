using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class ColdFood:BaseProduct
    {
        public ColdFood(string name, string weight, int price)
        {
            this.name = name;
            this.weight = weight;
            this.price = price;
        }

        public override void Examine()
        {
            Console.Write($"Name: {name} - ");
            Console.Write($"Fresh and tasty {name} - ");
            Console.WriteLine($"Price {price} kr");
        }
        public override string Use()
        {
            return $"Just open and eat the {name}!";
        }
    }
}
