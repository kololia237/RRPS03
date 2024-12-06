using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.Bridge
{
    public class SendVegeterianOrder : SendOrder
    {
        public override string Send()
        {
            return _cakes.Cake("Вегетеріанський ", 80);
        }
    }
}
