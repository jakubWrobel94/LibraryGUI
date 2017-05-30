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
    public partial class InfoMultiVolume : InformationWindow
    {
        public InfoMultiVolume()
        {
            InitializeComponent();
        }

        public InfoMultiVolume(string TITLE,string AUTHOR, string GENERE, int YEAR,int COPIES,int VOLUMES,int INDEX)
        {
            InitializeComponent();
            textBoxtTitle.Text = TITLE;
            textBoxAuthor.Text = AUTHOR;
            textBoxGenre.Text = GENERE;
            textBoxYear.Text = System.Convert.ToString(YEAR);
            textBoxCopies.Text = System.Convert.ToString(COPIES);

            textBoxVolumes.Text = System.Convert.ToString(VOLUMES);
            bookIndex = INDEX;
        }
    }
}
