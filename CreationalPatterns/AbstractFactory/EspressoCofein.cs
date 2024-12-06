using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.AbstractFactory
{
    public class EspressoCofein : IWithCofein
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public EspressoCofein()
        {
            Name = "Еспресо з кофеїном";
            Price = 10;
        }
        public string GetModelDetails()
        {
            return $"{Name} - {Price}";
        }
    }
}
