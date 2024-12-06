using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.AbstractFactory
{
    public class CappucinoCofeinFree : INoCofein
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public CappucinoCofeinFree()
        {
            Name = "Капучіно без кофеїну";
            Price = 27;
        }
        public string GetModelDetails()
        {
            return $"{Name} - {Price}";
        }
    }
}
