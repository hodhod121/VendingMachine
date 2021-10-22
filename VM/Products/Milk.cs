using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Milk:BaseProduct
    {
        public override int price()
        {
            return 39;
        }
        public string name = "Milk";
        public string weight = "100g";

        public Milk(string name, string weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public override void Examine()
        {
            Console.Write($"Name: {name} - ");
            Console.Write($"Very fresh and tasty {name} - ");
            Console.WriteLine($"Price {price()} kr");
        }
        public override string Use()
        {
            return $"Just open and drink the {name}!";
        }
    }
}
