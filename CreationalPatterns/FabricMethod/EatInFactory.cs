using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.FabricMethod
{
    class EatInFactory : OrderFactory
    {
        private int OrderId;
        private double Price;

        public EatInFactory(int orderid, double pr)
        {
            OrderId = orderid;
            Price = pr;
        }
        public override Order GetOrderType()
        {
            return new Order_EatIn(OrderId, Price);
        }
    }
}
