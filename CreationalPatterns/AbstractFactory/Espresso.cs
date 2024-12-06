using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.AbstractFactory
{
    public class Espresso : ICoffee
    {
        public INoCofein GetNoCofein()
        {
            return new EspressoCofeinFree();
        }

        public IWithCofein GetWithCofein()
        {
            return new EspressoCofein();
        }
    }
}
