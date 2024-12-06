using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.FabricMethod
{
    abstract class OrderFactory
    {
        public abstract Order GetOrderType();
    }

}
