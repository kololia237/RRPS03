using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.StructuralPatterns.Facade
{
    public class Coffee
    {
        public bool CheckCoffee(Customer c)
        {
            Console.WriteLine("Перевірка чи замовляли " + c.Name);
            return true;
        }
    }
}
