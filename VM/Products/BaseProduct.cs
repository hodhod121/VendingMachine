using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    abstract public class BaseProduct
    {
        public int price { get; set; }
        public string name { get; set; }
        public string weight { get; set; }

        public abstract string Examine();

        public abstract string Use();

    }
}
