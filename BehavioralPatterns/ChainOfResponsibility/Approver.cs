using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.BehavioralPatterns.ChainOfResponsibility
{
    public abstract class Approver
    {
        protected Approver appr;

        public void SetSuccessor(Approver appr)
        {
            this.appr = appr;
        }

        public abstract string ProcessRequest(Purchase purchase);
    }
}
