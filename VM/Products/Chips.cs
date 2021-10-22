﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Chips:BaseProduct
    {

        public Chips(string name, string weight, int price)
        {
            this.name = name;
            this.weight = weight;
            this.price = price;
        }

        public override void Examine()
        {
            Console.Write($"Name: {name} - ");
            Console.Write($"The best {name} - ");
            Console.WriteLine($"Price {price} kr");
        }
        public override string Use()
        {
            return $"Eat {name} just like that or with yoghurt!";
        }
    }
}
