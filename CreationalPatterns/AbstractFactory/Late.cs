using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.AbstractFactory
{
    public class Late : ICoffee
    {
        public INoCofein GetNoCofein()
        {
            return new LateCofeinFree();
        }

        public IWithCofein GetWithCofein()
        {
            return new LateCofein();
        }
    }
}
