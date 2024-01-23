using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Video_23
{
    class Person
    {
        //instance variable
        public string firstName;
        public string middleName;
        public string lastName;

            public string GetName()
        {
            //local variable
            string fullName = firstName + " " + middleName + " " + lastName;
            return fullName;
        }
    }
}
