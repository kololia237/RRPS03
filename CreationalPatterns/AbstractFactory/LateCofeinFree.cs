using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.AbstractFactory
{
    public class LateCofeinFree : INoCofein
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public LateCofeinFree()
        {
            Name = "Лате без кофеїну";
            Price = 35;
        }
        public string GetModelDetails()
        {
            return $"{Name} - {Price}";
        }
    }
}
