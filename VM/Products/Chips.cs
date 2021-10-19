using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VM.Products
{
    class Chips:BaseProduct
    {
        public int price()
        {
            return 47;
        }
        public string name = "Chips";

        public override void Examine()
        {
            Console.Write($"Name: {name} - ");
            Console.Write($"Very tasty {name} - ");
            Console.WriteLine($"Price {price()} kr");
        }
        public override string Use()
        {
            return $"Eat {name} just like that or with yoghurt!";
        }
    }
}
