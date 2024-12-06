using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.BehavioralPatterns.Iterator
{
    public interface IBookNumerable//•	Aggregate
    {
        IBookIterator CreateNumerator();
        int Count { get; }
        Book_It this[int index] { get; }
    }
}
