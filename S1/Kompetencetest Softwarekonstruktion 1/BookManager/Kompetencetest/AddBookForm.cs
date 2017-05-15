using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagerProject
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            if(InformationFilled())
            {
                Form1 f1 = Owner as Form1;
                f1.AddBook(new Book(titleTB.Text, isbnTB.Text, authorTB.Text, (int)amountNum.Value, isPaperbackCB.Checked), true);
                Close();
            }
        }

        private bool InformationFilled()
        {
            return titleTB.Text != string.Empty && isbnTB.Text != string.Empty && authorTB.Text != string.Empty;
        }
    }
}
