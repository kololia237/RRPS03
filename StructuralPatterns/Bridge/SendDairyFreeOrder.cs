using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.Bridge
{
    public class SendDairyFreeOrder : SendOrder
    {
        public override string Send()
        {
            return _cakes.Cake("Безлактозний ", 67);
        }
    }
}
