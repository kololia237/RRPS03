using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.Bridge
{
    public abstract class SendOrder//define a method for sending an order and keep a reference to the Implementor
    {
        //Reference to the Implementor
        public ICakes _cakes;

        public abstract string Send();
    }
}
