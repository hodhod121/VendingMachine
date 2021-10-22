using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class FreshFruit:BaseProduct
    {
        public override int price()
        {
            return 42;
        }
        public string name = "FreshFruit";
        public string weight = "100g";

        public FreshFruit(string name, string weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public override void Examine()
        {
            Console.Write($"Name: {name} - ");
            Console.Write($"Fresh {name} - ");
            Console.WriteLine($"Price {price()} kr");
        }
        public override string Use()
        {
            return $"Just open and eat the {name}!";
        }
    }
}
