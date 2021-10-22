﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Coffee:BaseProduct
    {
        public override int price()
        {
            return 35;
        }
        public string name = "Coffee";
        public string weight = "100g";

        public Coffee(string name, string weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public override void Examine()
        {
            Console.Write($"Name: {name} - ");
            Console.Write($"Fresh {name} - ");
            Console.WriteLine($"Price {price()} kr");
        }
        public override string Use()
        {
            return $"Just drink the {name}. Be careful, it is hot!";
        }
    }
}
