using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.StructuralPatterns.Decorator
{
    public class Borrowable : Decorator
    {
        protected readonly List<string> borrowers = new List<string>();

        // Constructor

        public Borrowable(LibraryItem libraryItem)
            : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            libraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            libraryItem.NumCopies++;
        }

        public override string Display()
        {
            base.Display();
            string borrow="";

            foreach (string borrower in borrowers)
            {
                borrow = "Клієнт : " + borrower;
            }
            return borrow;
        }
    }
}
