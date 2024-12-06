using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.Prototype
{
    public class Waiter : IEmployee
    {
        public string? Name { get; set; }
        public string? Role { get; set; }
        public int Salary { get; set; }
        public int WorkingHours { get; set; }

        public IEmployee Clone()
        {
            // Shallow Copy
            return (IEmployee)MemberwiseClone();

            // Deep Copy
            //return (IEmployee)this.Clone();
        }

        public string GetDetails()
        {
            return string.Format($"{Name} - {Role}");
        }
    }

}
