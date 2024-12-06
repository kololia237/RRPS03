using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.StructuralPatterns.Proxy
{
    public interface IToDB
    {
        string PerformRWOperations();
    }
}
