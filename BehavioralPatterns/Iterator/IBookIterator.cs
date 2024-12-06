using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.BehavioralPatterns.Iterator
{
    public interface IBookIterator //•	Iterator
    {
        bool HasNext();
        Book_It Next();
    }
}
