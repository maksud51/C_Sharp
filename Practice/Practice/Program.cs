using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.setBookName("Maksud");
            b1.setBookAuthor("Alam");
            b1.setBookCopy(20);
            b1.setBookId("as1234");
            b1.setBookType("Biography");
            b1.ShowInfo();
            Book.ShowTotalBookInfo();

            Contact p1 = new Contact("p1", "a123", 35, "018424424242", 'M');
            p1.ShowPersonInfo();
            p1.detectMobileOperator();

            Contact p2 = new Contact();
            p2.setPersonName("P2");
            p2.setAge(35);
            p2.setGender('M');
            p2.setMobileNumber("01856258552");
            p2.setPersonId("sdd256sdf");
            p2.ShowPersonInfo();
            p2.detectMobileOperator();
        }
    }
}
