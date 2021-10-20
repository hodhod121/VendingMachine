using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class FreshFruit:BaseProduct
    {
        public int price()
        {
            return 42;
        }
        public string name = "FreshFruit";

        public override void Examine()
        {
            Console.Write($"Name: {name} - ");
            Console.Write($"Very tasty {name} - ");
            Console.WriteLine($"Price {price()} kr");
        }
        public override string Use()
        {
            return $"Just open and eat the {name}!";
        }
    }
}
