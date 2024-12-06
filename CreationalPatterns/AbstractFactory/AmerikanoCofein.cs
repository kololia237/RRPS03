using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.AbstractFactory
{
    public class AmerikanoCofein : IWithCofein
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public AmerikanoCofein()
        {
            Name = "Американо з кофеїном";
            Price = 17;
        }
        public string GetModelDetails()
        {
            return $"{Name} - {Price}";
        }
    }
}
