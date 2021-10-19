using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VM.Products
{
    class ColdFood:BaseProduct
    {
        public int price()
        {
            return 345;
        }
        public string name = "ColdFood";

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
