using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
      public  class Candy:BaseProduct
    {          
        public override  int price()
        {
            return 32;
        }
        public string name = "Candy";
        public string weight = "100g";

        public Candy(string name, string weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public override void Examine()
        {
            Console.Write($"Name: {name} - ");
            Console.Write($"Very tasty {name} - ");
            Console.WriteLine($"Price {price()} kr");
        }
        public override string Use()
        {
            return $"Just open and eat {name}!";
        }
    }
}
