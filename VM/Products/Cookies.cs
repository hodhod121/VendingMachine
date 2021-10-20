﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Cookies:BaseProduct
    {
        public int price()
        {
            return 78;
        }
        public string name = "Cookies";

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
