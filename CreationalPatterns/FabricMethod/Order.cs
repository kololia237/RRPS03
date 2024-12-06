using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.FabricMethod
{
    abstract class Order
    {
        public abstract string Name { get;  }
        public abstract int OrderId { get; set; }
        public abstract double Price { get; set; }
    }
}
