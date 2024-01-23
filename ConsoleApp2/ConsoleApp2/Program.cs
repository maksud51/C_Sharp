using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class.Book b1 = new Class.Book();
            b1.setBookName("Lions");
            b1.setBookAuthor("Jany");
            b1.setBookCopy(20);
            b1.setBookId("154sd");
            b1.setBookType("Biography");
            b1.showInfo();
            Class.Book.ShowTotalBookInfo();

            Class.Contact p1 = new Class.Contact();
            p1.setPersonName("Maksud");
            p1.setAge(20);
            p1.setGender('M');
            p1.setMobileNumber("01856258552");
            p1.setPersonId("sdd256sdf");
            p1.showPersonInfo();
            p1.detectMobileOperator();
        }
    }
}
