using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.StructuralPatterns.Composite
{
    public class Leaf : IntComponent
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public Leaf(string name, int price, int num)
        {
            this.Price = price;
            this.Name = name;
            this.Number = num;
        }

        public int DisplayPrice()
        {
           //return string.Format($"{Name} : {Price}. Кількість: {Number}");
           return Price*Number;

        }
    }
}
