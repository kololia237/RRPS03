using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.StructuralPatterns.Facade
{
    public class ConfirmOrder
    {
        Cafe cafe = new Cafe();
        Cake cake = new Cake();
        Coffee coffee = new Coffee();

        public bool IsEligible(Customer cust, int amount)
        {

            bool confirm = true;

            // Check creditworthyness of applicant

            if (!cafe.HasSavings(cust, amount))
            {
                confirm = false;
            }
            else if (!cake.CheckCake(cust))
            {
                confirm = false;
            }
            else if (!coffee.CheckCoffee(cust))
            {
                confirm = false;
            }

            return confirm;
        }
    }
}
