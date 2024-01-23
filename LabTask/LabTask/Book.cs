using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
{
    internal class Book
    {
        private string bookName;
        private string bookAuthor;
        private string bookId;
        private string bookType;
        private int bookCopy;
        private static int bookCounter;

        public Book()
        {
            bookCounter++;
        }
        public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
            bookCounter++;
        }

        public void setBookName(string bookName)
        {
            this.bookName = bookName;
        }

        public string getBookName()
        {
            return this.bookName;
        }

        public void setBookAuthor(string bookAuthor)
        {
            this.bookAuthor = bookAuthor;
        }

        public string getBookAuthor()
        {
            return this.bookAuthor;
        }

        public void setBookId(string bookId)
        {
            this.bookId = bookId;
        }

        public string getBookId()
        {
            return this.bookId;
        }

        public void setBookType(string bookType)
        {
            this.bookType = bookType;
        }

        public string getBookType()
        {
            return this.bookType;
        }

        public void setBookCopy(int bookCopy)
        {
            this.bookCopy = bookCopy;
        }

        public int getBookCopy()
        {
            return this.bookCopy;
        }

        public static void ShowTotalBookInfo()
        {
            Console.WriteLine("Total books added: " + bookCounter);
        }

        public void showInfo()
        {
            Console.WriteLine("Book name: " + this.bookName);
            Console.WriteLine("Book author: " + this.bookAuthor);
            Console.WriteLine("Book type: " + this.bookType);
            Console.WriteLine("Book copy: " + this.bookCopy);
            Console.WriteLine("Book id: " + this.bookId);
        }
    }
}