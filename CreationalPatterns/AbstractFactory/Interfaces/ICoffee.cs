using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.AbstractFactory
{
    public interface ICoffee
    {
        INoCofein GetNoCofein();
        IWithCofein GetWithCofein();
    }
}
