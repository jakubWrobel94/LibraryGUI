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
    public partial class InfoIlustratedBook : InformationWindow
    {
        public InfoIlustratedBook()
        {
            InitializeComponent();
        }

        public InfoIlustratedBook(string TITLE, string AUTHOR, string GENERE, int YEAR, int COPIES, string ILUSTRATOR , int INDEX)
        {
            InitializeComponent();
            textBoxtTitle.Text = TITLE;
            textBoxAuthor.Text = AUTHOR;
            textBoxGenre.Text = GENERE;
            textBoxYear.Text = System.Convert.ToString(YEAR);
            textBoxCopies.Text = System.Convert.ToString(COPIES);

            textBoxIlustrator.Text = ILUSTRATOR;
            bookIndex = INDEX;

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
