using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.Builder
{
    public interface CoffeeBuilder
    {
        int SetSugar(int sugar);
        string SetSyrup(string syrup);
        string SetIceCoffee(bool ice);
        SpecialCoffee GetCoffee();
    }
}
