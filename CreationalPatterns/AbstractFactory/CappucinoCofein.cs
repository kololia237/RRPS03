using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.AbstractFactory
{
    public class CappucinoCofein : IWithCofein
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public CappucinoCofein()
        {
            Name = "Капучіно з кофеїном";
            Price = 25;
        }
        public string GetModelDetails()
        {
            return $"{Name} - {Price}";
        }
    }
}
