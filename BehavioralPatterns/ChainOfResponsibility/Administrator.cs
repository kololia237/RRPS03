using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.BehavioralPatterns.ChainOfResponsibility
{
    public class Administrator : Approver
    {
        public override string ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount > 1000.0 && purchase.Amount < 2000.0)
            {
                return $"{this.GetType().Name} затверджено замовлення #{purchase.Number}";
            }
            else
            {
                return $"Зaмовлення # {purchase.Number} потребує додаткової зустрічі";
            }
        }
    }
}
