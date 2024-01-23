using System;

namespace LabTask
{
    class Program 
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.setBookName("Lions");
            b1.setBookAuthor("Jany");
            b1.setBookCopy(20);
            b1.setBookId("154sd");
            b1.setBookType("Biography");
            b1.showInfo();
            Book.ShowTotalBookInfo();

            Contact p1 = new Contact();
            p1.setPersonName("P1");
            p1.setAge(35);
            p1.setGender('M');
            p1.setMobileNumber("01856258552");
            p1.setPersonId("sdd256sdf");
            p1.showPersonInfo();
            p1.detectMobileOperator();
        }
    }
}
