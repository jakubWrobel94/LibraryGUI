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
    public partial class Biblioteka : Form
    {
        public BookCatalog catalog;
        
        public Biblioteka()
        {
            string fileName = "catalog.txt";
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, @"catalog\", fileName);
            InitializeComponent();
            catalog = new BookCatalog(path);
        
        }

        private void ButtonShowInfoWindow_Click(object sender, EventArgs e)
        {
            InformationWindow.catalog.ShowInformationWindow(0);
            //InformationWindow infoWindow = new InformationWindow();
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchWindow newWindow = new SearchWindow();
            newWindow.Show();
        }
    }
}
