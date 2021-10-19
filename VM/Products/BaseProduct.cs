using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VM.Products
{
     abstract class BaseProduct
    {
        public abstract void Examine();
        public abstract string Use();
    }
}
