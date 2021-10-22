using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
       abstract public class BaseProduct
    {       
        public abstract int price();

        public abstract void Examine();

        public abstract string Use();

    }
}
