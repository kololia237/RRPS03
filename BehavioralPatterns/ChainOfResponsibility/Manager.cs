using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.BehavioralPatterns.ChainOfResponsibility
{
    public class Manager : Approver
    {
        public override string ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 250.0)
            {
                return $"{this.GetType().Name} затверджено замовлення #{purchase.Number}";
            }
            else if (appr != null)
            {
                return appr.ProcessRequest(purchase);
            }
            return "";
        }
        
    }
}
