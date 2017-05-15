using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BookManagerProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BookStorage.LoadBooks();
            LoadBooks();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BookStorage.SaveBooks();
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            AddBookForm abf = new AddBookForm();
            abf.ShowDialog(this);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(searchBarTB.Text == string.Empty)
            {
                if (BookStorage.Books.Count != listView1.Items.Count)
                {
                    RefreshBooks();
                    return;
                }
            }

            listView1.Items.Clear();
            // Loop through books
            for (int i = 0; i < BookStorage.Books.Count; i++)
            {
                Book book = BookStorage.Books[i];
                // Check if book starts the search text
                if (book.Title.ToLower().StartsWith(searchBarTB.Text.ToLower()))
                {
                    AddBook(book, false);
                }
            }

        }

        public void AddBook(Book newBook, bool addToStorage)
        {
            ListViewItem lvi = new ListViewItem();
            ListViewItem.ListViewSubItem[] subItems = new ListViewItem.ListViewSubItem[4];
            subItems[0] = new ListViewItem.ListViewSubItem(); // ISBN
            subItems[1] = new ListViewItem.ListViewSubItem(); // Author
            subItems[2] = new ListViewItem.ListViewSubItem(); // Amount
            subItems[3] = new ListViewItem.ListViewSubItem(); // IsPaperback

            lvi.Tag = newBook;
            lvi.Text = newBook.Title;
            subItems[0].Text = newBook.ISBN;
            subItems[1].Text = newBook.Author;
            subItems[2].Text = newBook.Amount.ToString();
            subItems[3].Text = newBook.IsPaperback ? "Yes" : "No";

            lvi.SubItems.AddRange(subItems);
            listView1.Items.Add(lvi);

            if(addToStorage)
            {
                BookStorage.Books.Add(newBook);
            }
        }

        private void LoadBooks()
        {
            for (int i = 0; i < BookStorage.Books.Count; i++)
            {
                AddBook(BookStorage.Books[i], false);
            }
        }

        private void RefreshBooks()
        {
            listView1.Items.Clear();
            LoadBooks();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedIndices.Count > 0)
            {
                int index = listView1.SelectedIndices[0];
                BookStorage.RemoveBook(listView1.Items[index].Tag as Book);
                listView1.Items.RemoveAt(index);
            }
        }
    }
}
