using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.BehavioralPatterns.ChainOfResponsibility
{
    public class Director : Approver
    {
        public override string ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount > 250.0 && purchase.Amount < 1000.0)
            {
                return $"{this.GetType().Name} затверджено замовлення #{purchase.Number}";
            }
            else if (appr != null)
            {
                appr.ProcessRequest(purchase);
            }
            return "";
        }
    }
}
