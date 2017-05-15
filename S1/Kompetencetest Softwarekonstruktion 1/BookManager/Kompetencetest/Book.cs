using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagerProject
{
    public class Book
    {
        public string Title { get; private set; }
        public string ISBN { get; private set; }
        public string Author { get; private set; }
        public int Amount { get; private set; }
        public bool IsPaperback { get; private set; }

        public Book(string title, string isbn, string author, int amount, bool isPaperback)
        {
            Title = title;
            ISBN = isbn;
            Author = author;
            Amount = amount;
            IsPaperback = isPaperback;
        }
    }
}
