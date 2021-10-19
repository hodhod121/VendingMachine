using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VM.Products
{
    class Milk:BaseProduct
    {
        public int price()
        {
            return 32;
        }
        public string name = "Milk";

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
