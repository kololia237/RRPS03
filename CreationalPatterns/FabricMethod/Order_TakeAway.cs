using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.FabricMethod
{
    class Order_TakeAway: Order
    {
        private readonly string name;
        private int orderId;
        private double price;

        public Order_TakeAway(int orderid, double pr)
        {
            name = "Замовлення з собою";
            orderId = orderid;
            price = pr;
        }
        public override string Name
        {
            get { return name; }
        }

        public override int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public override double Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}
