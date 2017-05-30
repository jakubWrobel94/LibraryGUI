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
    
    public partial class SearchWindow : Form
    {
        public List<Book> foundBooks;
        public SearchWindow()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            if (comboBoxCondition.SelectedItem != null)
            {
                foundBooks = new List<Book>();
                string querry = textBoxQuery.Text;

                if (comboBoxCondition.SelectedItem.ToString() == "Tytuł")
                {
                   
                    foreach(Book book in catalog.Books)
                    {
                        if (book.Title.Contains(querry)) foundBooks.Add(book);
                    }
                   
                }

                if (comboBoxCondition.SelectedItem.ToString() == "Autor")
                {

                    foreach (Book book in catalog.Books)
                    {
                        if (book.AuthorName.Contains(querry)) foundBooks.Add(book);
                    }

                }

                if (comboBoxCondition.SelectedItem.ToString() == "Gatunek")
                {

                    foreach (Book book in catalog.Books)
                    {
                        if (book.Genre.Contains(querry)) foundBooks.Add(book);
                    }

                }

                if (comboBoxCondition.SelectedItem.ToString() == "Rok wydania")
                {

                    foreach (Book book in catalog.Books)
                    {
                        int querryInt = Convert.ToInt16(querry);
                        if (book.RelaseYear== querryInt) foundBooks.Add(book);
                    }

                }

                listBox1.Items.Clear();
                foreach (Book foundBook in foundBooks)
                {
                    string output = foundBook.Title + '\t' + foundBook.AuthorName;
                    listBox1.Items.Add(output);
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int bookIndex = listBox1.SelectedIndex;
            foundBooks[bookIndex].showInformationWindow();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Show();
        }
    }
}
