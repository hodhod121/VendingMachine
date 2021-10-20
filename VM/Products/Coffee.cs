using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Coffee:BaseProduct
    {
        public int price()
        {
            return 35;
        }
        public string name = "Coffee";

        public override void Examine()
        {
            Console.Write($"Name: {name} - ");
            Console.Write($"Very tasty {name} - ");
            Console.WriteLine($"Price {price()} kr");
        }
        public override string Use()
        {
            return $"Just drink the {name}. Be careful, it is hot!";
        }
    }
}
