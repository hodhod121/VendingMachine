using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VM.Products
{
    abstract class Candy:BaseProduct
    {
        public override void Examine()
        {
            Console.WriteLine("Munch, Munch, YUM!"); 
        }     
        public override void Use()
        {
            Console.WriteLine("Just open and eat!");
        }
    }
}
