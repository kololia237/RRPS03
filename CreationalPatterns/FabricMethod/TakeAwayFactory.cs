using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.FabricMethod
{
    class TakeAwayFactory: OrderFactory
    {
        private int OrderId;
        private double Price;

        public TakeAwayFactory(int orderid, double pr)
        {
            OrderId = orderid;
            Price = pr;
        }
        public override Order GetOrderType()
        {
            return new Order_TakeAway(OrderId, Price);
        }
    }
}
