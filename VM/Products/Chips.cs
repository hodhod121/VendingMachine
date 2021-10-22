using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Chips:BaseProduct
    {
        public override int price()
        {
            return 47;
        }
        public string name = "Chips";
        public string weight = "100g";

        public Chips(string name, string weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public override void Examine()
        {
            Console.Write($"Name: {name} - ");
            Console.Write($"The best {name} - ");
            Console.WriteLine($"Price {price()} kr");
        }
        public override string Use()
        {
            return $"Eat {name} just like that or with yoghurt!";
        }
    }
}
