using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.AbstractFactory
{
    public class AmerikanoCofeinFree : INoCofein
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public AmerikanoCofeinFree()
        {
            Name = "Американо без кофеїну";
            Price = 15;
        }
        public string GetModelDetails()
        {
            return $"{Name} - {Price}";
        }
    }
}
