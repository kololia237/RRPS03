using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.StructuralPatterns.Facade
{

    public class Cake
    {
        public bool CheckCake(Customer c)
        {
            Console.WriteLine("Перевірка чи замовляли " + c.Name);
            return true;
        }
    }
}
