using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.BehavioralPatterns.Iterator
{
    public class Library : IBookNumerable//•	ConcreteAggregate
    {
        private Book_It[] books;
        public Library()
        {
            books = new Book_It[]
            {
            new Book_It{Name="Война и мир"},
            new Book_It {Name="Отцы и дети"},
            new Book_It {Name="Вишневый сад"}
            };
        }
        public int Count
        {
            get { return books.Length; }
        }

        public Book_It this[int index]
        {
            get { return books[index]; }
        }
        public IBookIterator CreateNumerator()
        {
            return new LibraryNumerator(this);
        }
    }
}
