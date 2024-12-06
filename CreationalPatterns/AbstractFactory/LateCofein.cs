using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.AbstractFactory
{
    public class LateCofein : IWithCofein
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public LateCofein()
        {
            Name = "Лате з кофеїном";
            Price = 30;
        }
        public string GetModelDetails()
        {
            return $"{Name} - {Price}";
        }
    }
}
