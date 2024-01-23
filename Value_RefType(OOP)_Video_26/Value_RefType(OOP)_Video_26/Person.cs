using System;
using System.Collections.Generic;
using System.Text;

namespace Value_RefType_OOP__Video_26
{
    class Person
    {
        public string fName;
        public string mName;
        public string lName;

        public string GetFullName()
        {
            string FullName = fName + " " + mName + " " + lName;
            return FullName;
        }
    }
}
