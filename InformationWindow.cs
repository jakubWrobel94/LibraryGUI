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
    public partial class InformationWindow : Form
    {
        public InformationWindow()
        {
            InitializeComponent();
            
        }

        private void buttonNextBook_Click(object sender, EventArgs e)
        {
            
            if (bookIndex < catalog.Books.Count - 1)
            {
                //catalog.getBook(bookIndex + 1).showInformationWindow();
                InformationWindow newWindow = catalog.getBook(bookIndex + 1).showInformationWindow();

                this.Close();
               
                newWindow.Show();
                newWindow.Location = this.Location;
            }
        }

        private void buttonPrevBook_Click(object sender, EventArgs e)
        {
            if (bookIndex > 0)
            {
                InformationWindow newWindow = catalog.getBook(bookIndex - 1).showInformationWindow();
                //InformationWindow newWindow = new InformationWindow(catalog.getBook(bookIndex - 1));

                this.Close();

                newWindow.Show();
                newWindow.Location = this.Location;
            }
        }

        private void buttonLend_Click(object sender, EventArgs e)
        {
            RentWindow newWindow = new RentWindow(catalog.Books[bookIndex]);
            newWindow.Show();

        }
    }
}
