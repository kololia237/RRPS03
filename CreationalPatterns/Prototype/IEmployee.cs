using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.Prototype
{
    public interface IEmployee
    {
        IEmployee Clone();
        string GetDetails();
    }

}
