using System;

namespace ValueType_Vs_RefType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;


            Change(number);
            Console.WriteLine(number);
            Console.ReadKey();

/*            Person p1 = new Person();
            p1.firstName = "Md";
            p1.middleName = "Al";
            p1.lastName = "Maksud";
            Change(p1);
            Console.WriteLine(p1.lastName);*/
        }

        public static void Change(int a)
        {
            a = 20;

            Console.WriteLine(a);
        }

        /*        public static void Change(Person person)
                {
                    person.firstName = "Rana";
                    person.lastName = "Abid";
                }*/
    }
}
