using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class IlustratedBook : Book
    {
        private string ilustratorName { get; set; }

        public override InformationWindow showInformationWindow()
        {
            InformationWindow infoWindow = new InfoIlustratedBook(Title, AuthorName, Genre, RelaseYear, CopiesNumber, ilustratorName, index);
            return infoWindow;
        }
        public IlustratedBook(string TITLE, string AUTHOR_NAME, string GENRE, int YEAR, int COPIES, string ILUSTRATOR_NAME, int IDX)
        {
            Title = TITLE;
            AuthorName = AUTHOR_NAME;
            Genre = GENRE;
            RelaseYear = YEAR;
            CopiesNumber = COPIES;
            ilustratorName = ILUSTRATOR_NAME;
            index = IDX;
        }
    }
}
