using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.BehavioralPatterns.Iterator
{
    public class Reader//•	Client
    {
        public void SeeBooks(Library library)
        {
            IBookIterator iterator = library.CreateNumerator();
            while (iterator.HasNext())
            {
                Book_It book = iterator.Next();
                Console.WriteLine(book.Name);
            }
        }
    }
}
