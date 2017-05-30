using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class MultiVolumeBook: Book
    {
        public int VolumesNumber { get; set; }

        public MultiVolumeBook() { }
        public MultiVolumeBook(string TITLE, string AUTHOR_NAME, string GENRE, int YEAR, int COPIES,int VOL_NUMB, int IDX)
        {
            Title = TITLE;
            AuthorName = AUTHOR_NAME;
            Genre = GENRE;
            RelaseYear = YEAR;
            CopiesNumber = COPIES;
            VolumesNumber = VOL_NUMB;
            index = IDX;
        }

        public override InformationWindow showInformationWindow()
        {
            InformationWindow infoWindow = new InfoMultiVolume(Title,AuthorName,Genre,RelaseYear,CopiesNumber,VolumesNumber,index);
            return infoWindow;
        }
    }
}
