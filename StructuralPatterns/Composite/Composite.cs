using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.StructuralPatterns.Composite
{
    public class Composite : IntComponent
    {
        public string Name { get; set; }
        List<IntComponent> components = new List<IntComponent>();
        public Composite(string name)
        {
            this.Name = name;
        }
        public void AddComponent(IntComponent component)
        {
            components.Add(component);
        }

        public int DisplayPrice()
        {
            int all = 0;
            foreach (var item in components)
            {
                all+=item.DisplayPrice();
            }
            return all;
        }
    }
}
