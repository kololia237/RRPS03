using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.AbstractFactory
{
    public class EspressoCofeinFree : INoCofein
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public EspressoCofeinFree()
        {
            Name = "Еспресо без кофеїну";
            Price = 12;
        }
        public string GetModelDetails()
        {
            return $"{Name} - {Price}";
        }
    }
}
