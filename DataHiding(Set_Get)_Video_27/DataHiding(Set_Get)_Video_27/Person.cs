using System;
using System.Collections.Generic;
using System.Text;

namespace DataHiding_Set_Get__Video_27
{
    class Person
    {
        private string fName;
        private string mName;
        private string lName;

/*        public void SetfName(string fName)
        {
            if (fName.Length >= 2)
            {
                this.fName = fName;
            }
        }

        public string GetfName()
        {
            return this.fName;
        }*/
         
                  //or

/*        public string FirstName
        {
            set {
                    if(value.Length >= 2)
                    {
                       fName = value;
                    }
               }
            get { return fName; }

        }*/
                  //or

        /*public string FName { get => fName; set => fName = value; }
*/

        //or Auto Property

         
        public string FirstName { get; private set; }
        public string GetFullName()
        {
            string FullName = fName + " " + mName + " " + lName;
            return FullName;
        }
    }
}
