using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Cookies:BaseProduct
    {
        public override int price()
        {
            return 78;
        }
        public string name = "Cookies";
        public string weight = "100g";

        public Cookies(string name, string weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public override void Examine()
        {
            Console.Write($"Name: {name} - ");
            Console.Write($"New made {name} - ");
            Console.WriteLine($"Price {price()} kr");
        }
        public override string Use()
        {
            return $"Just open and eat the {name}!";
        }
    }
}
