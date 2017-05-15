using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BookManagerProject
{
    public static class BookStorage
    {
        public static List<Book> Books { get; private set; } = new List<Book>();

        public static void SaveBooks()
        {
            if (Books.Count == 0)
            {
                return;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Books.Count; i++)
            {
                Book book = Books[i];
                sb.AppendLine(string.Format("{0}|{1}|{2}|{3}|{4}", book.Title, book.ISBN, book.Author, book.Amount, book.IsPaperback));
            }
            File.WriteAllText("Books.txt", sb.ToString());
        }

        public static void LoadBooks()
        {
            if (!File.Exists("Books.txt"))
            {
                return;
            }

            string[] fileText = File.ReadAllLines("Books.txt");
            for (int i = 0; i < fileText.Length; i++)
            {
                string[] split = fileText[i].Split('|');
                Book book = new Book(split[0], split[1], split[2], int.Parse(split[3]), Convert.ToBoolean(split[4]));
                Books.Add(book);
            }
        }

        public static void RemoveBook(Book book)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if(Books[i].ISBN == book.ISBN)
                {
                    Books.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
