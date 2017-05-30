using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class RentWindow : Form
    {
        public Book book;
        public RentWindow()
        {
            InitializeComponent();
        }

        public RentWindow(Book BOOK)
        {
            InitializeComponent();
            book = BOOK;
            refreshList();
        }

        public void refreshList()
        {
            foreach(Book.Lend lend in book.LendList )
            {
                this.listBox1.Items.Add("Wypożyczył : " + lend.name + "\t Data zwrotu : " + lend.date);
            }
        }

        public void addToList()
        {
            Book.Lend lastLend = book.LendList[book.LendList.Count - 1];
            this.listBox1.Items.Add("Wypożyczył : " + lastLend.name + "\t Data zwrotu : " + lastLend.date);
        }
        private void buttonRent_Click(object sender, EventArgs e)
        {
            if (book.CopiesNumber == 0) MessageBox.Show("Nie ma już egzemplarzy tej książki !");
            else
            {
                if (textBoxDate.Text != "" && textBoxName.Text != "")
                {
                    string date = textBoxDate.Text;
                    string name = textBoxName.Text;

                    book.LendList.Add(new Book.Lend(name, date));
                    book.CopiesNumber--;
                    addToList();
                }
            }
        }
    }
}
