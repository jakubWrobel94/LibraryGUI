using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public struct Lend
        {
            public string name;
            public string date;
            public Lend(string NAME, string DATE)
            {
                name = NAME;
                date = DATE; 
            }
        }

        public Book()
        {
            Title = "NN";
            AuthorName = "NN";
            Genre = "NN";
            RelaseYear = 0;
            CopiesNumber = 0;
            LendList = new List<Lend>();
        }
        public Book(string TITLE,string AUTHOR_NAME,string GENRE,int YEAR,int COPIES,int IDX)
        {
            Title = TITLE;
            AuthorName = AUTHOR_NAME;
            Genre = GENRE;
            RelaseYear = YEAR;
            CopiesNumber = COPIES;
            index = IDX;
            LendList = new List<Lend>();
        }

        public virtual InformationWindow showInformationWindow()
        {
            InformationWindow infoWindow = new InformationWindow(this);
            infoWindow.Show();
            return infoWindow;
        }

        public List<Lend> LendList;
        public string Title {get;set;}
        public string AuthorName { get; set; }
        public string Genre { get; set; }
        public int RelaseYear { get; set; }
        public int CopiesNumber { get; set; }
        public int index;

    }
}
