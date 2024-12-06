using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.Bridge
{
    public class MaffinOrders : ICakes
    {
        public string Cake(string order, int price)
        {
            return string.Format($"{order}Мафін. Ціна: {price}");
        }
    }
}
