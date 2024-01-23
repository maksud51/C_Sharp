using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    internal class Contact
    {
        private string personName;
        private string personId;
        private int age;
        private string mobileNumber;
        private char gender;

        public Contact()
        {

        }

        public Contact( string personName, string personId, int age, string mobileNumber, char gender)
        {
            this.personName = personName;
            this.personId = personId;
            this.age = age;
            this.mobileNumber = mobileNumber;
            this.gender = gender;
        }

        public void setPersonName(string personName)
        {
            this.personName = personName;
        }

        public string getPersonName()
        {
            return this.personName;
        }

        public void setPersonId(string personId)
        {
            this.personId = personId;
        }

        public string getPersonId()
        {
            return this.personId;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public int getAge()
        {
            return this.age;
        }

        public void setMobileNumber(string mobileNumber)
        {
            this.mobileNumber = mobileNumber;
        }

        public string getMobileNumber()
        {
            return this.mobileNumber;
        }

        public void setGender(char gender)
        {
            this.gender = gender;
        }

        public char getGender()
        {
            return this.gender;
        }

        public void ShowPersonInfo()
        {
            Console.WriteLine("Person name: " + this.personName);
            Console.WriteLine("Person id: " + this.personId);
            Console.WriteLine("Person age:" + this.age);
            Console.WriteLine("Person mobile number: " + this.mobileNumber);
            Console.WriteLine("Person gender: " + this.gender);
        }

        public void detectMobileOperator()
        {
            if (this.mobileNumber.StartsWith("017"))
            {
                Console.WriteLine("Gp");
            }

            else if (this.mobileNumber.StartsWith("018"))
            {
                Console.WriteLine("Robi");
            }
            else if (this.mobileNumber.StartsWith("019"))
            {
                Console.WriteLine("Banglalink");
            }
        }
    }
}
