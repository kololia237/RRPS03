using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.Builder
{
    public class YourCoffee:CoffeeBuilder
    {
        SpecialCoffee specialCoffee = new SpecialCoffee();
        public int SetSugar(int s)
        {
            specialCoffee.Sugar = s;
            return specialCoffee.Sugar;
        }
        public string SetSyrup(string s)
        {
            specialCoffee.Syrup = s;
            return specialCoffee.Syrup.ToString();
        }
        public string SetIceCoffee(bool ice)
        {
            specialCoffee.IceCoffee = ice;
            if (ice == true)
            {
                return "Охолоджена кава";
            }
            return "Гаряча кава";
        }
        public SpecialCoffee GetCoffee()
        {
            return specialCoffee;
        }
    }
}
