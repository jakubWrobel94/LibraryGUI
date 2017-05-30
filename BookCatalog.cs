using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BookCatalog
    {

        public List<Book> Books;

        public BookCatalog(string FILE_PATH)
        {
            Books = new List<Book>();
            AddCatalogFromFile(FILE_PATH);
        }

        ~BookCatalog()
        {
       
        }
        public Book getBook(int INDEX)
        {
            if (INDEX >= Books.Count) return Books[INDEX - 1];
            return Books[INDEX];
        }

        public InformationWindow ShowInformationWindow(int BOOK_INDEX)
        {
            return Books[BOOK_INDEX].showInformationWindow();
        }
        public void AddCatalogFromFile(string FILE_PATH)
        {
            string[] lines = System.IO.File.ReadAllLines(FILE_PATH);
            int bookType;
            int index = 0;
            foreach(string line in lines)
            {
                bookType = line[0] - '0';
                switch(bookType)
                {
                    case 1:
                        AddBook(line,index);
                        break;
                    case 2:
                        AddMultiVolumeBook(line,index);
                        break;
                    case 3:
                        AddIlustratedBook(line,index);
                        break;
                }
                index++;
            }
        }

        public void AddBook(string LINE,int IDX)
        {
            int frontIndex = 1;
            int endIndex = 1;
            int letters = 0;

            string title = GetNextStringFromLine(ref LINE,ref frontIndex,ref endIndex,ref letters);
            string authorName = GetNextStringFromLine(ref LINE, ref frontIndex, ref endIndex, ref letters);
            string genre = GetNextStringFromLine(ref LINE, ref frontIndex, ref endIndex, ref letters);
            string relaseYear = GetNextStringFromLine(ref LINE, ref frontIndex, ref endIndex, ref letters);
            int relaseYearInt = Convert.ToInt16(relaseYear);
            string copiesNumber = GetNextStringFromLine(ref LINE, ref frontIndex, ref endIndex, ref letters);
            int copiesNumInt = Convert.ToInt16(copiesNumber);

            Book newBook = new Book(title, authorName, genre, relaseYearInt, copiesNumInt,IDX);
            Books.Add(newBook);
        }

        public void AddIlustratedBook(string LINE, int IDX)
        {
            int frontIndex = 1;
            int endIndex = 1;
            int letters = 0;

            string title = GetNextStringFromLine(ref LINE, ref frontIndex, ref endIndex, ref letters);
            string authorName = GetNextStringFromLine(ref LINE, ref frontIndex, ref endIndex, ref letters);
            string genre = GetNextStringFromLine(ref LINE, ref frontIndex, ref endIndex, ref letters);
            string relaseYear = GetNextStringFromLine(ref LINE, ref frontIndex, ref endIndex, ref letters);
            int relaseYearInt = Convert.ToInt16(relaseYear);
            string copiesNumber = GetNextStringFromLine(ref LINE, ref frontIndex, ref endIndex, ref letters);
            int copiesNumInt = Convert.ToInt16(copiesNumber);
            string ilustratorName = GetNextStringFromLine(ref LINE, ref frontIndex, ref endIndex, ref letters);
            Book newBook = new IlustratedBook(title, authorName, genre, relaseYearInt, copiesNumInt,ilustratorName,IDX);
            Books.Add(newBook);
        }

        public void AddMultiVolumeBook(string LINE,int IDX)
        {
            int frontIndex = 1;
            int endIndex = 1;
            int letters = 0;

            string title = GetNextStringFromLine(ref LINE, ref frontIndex, ref endIndex, ref letters);
            string authorName = GetNextStringFromLine(ref LINE, ref frontIndex, ref endIndex, ref letters);
            string genre = GetNextStringFromLine(ref LINE, ref frontIndex, ref endIndex, ref letters);
            string relaseYear = GetNextStringFromLine(ref LINE, ref frontIndex, ref endIndex, ref letters);
            int relaseYearInt = Convert.ToInt16(relaseYear);
            string copiesNumber = GetNextStringFromLine(ref LINE, ref frontIndex, ref endIndex, ref letters);
            int copiesNumInt = Convert.ToInt16(copiesNumber);
            string volumeNum = GetNextStringFromLine(ref LINE, ref frontIndex, ref endIndex, ref letters);
            int volumeNumInt = Convert.ToInt16(volumeNum);
            Book newBook = new MultiVolumeBook(title, authorName, genre, relaseYearInt, copiesNumInt, volumeNumInt, IDX);
            Books.Add(newBook);
        }
        public string GetNextStringFromLine(ref string LINE,ref int FRONT_IDX,ref int END_IDX,ref int LETTERS)
        {
            SeachComa(ref LINE, ref END_IDX, ref LETTERS);
            string outputString = LINE.Substring(FRONT_IDX, LETTERS);
            RefreshIndex(ref FRONT_IDX, ref END_IDX, ref LETTERS);
            return outputString;
        }

        public void SeachComa(ref string LINE,ref int END_IDX,ref int LETTERS)
        {
            while(LINE[END_IDX]!=',')
            {
                END_IDX++;
                LETTERS++;
            }
        }

        public void RefreshIndex(ref int FRONT_IDX, ref int END_IDX, ref int LETTERS)
        {
            FRONT_IDX = END_IDX + 1;
            END_IDX++;
            LETTERS = 0;
        }
    }
}
