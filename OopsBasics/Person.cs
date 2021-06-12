using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.OopsBasics
{
    public class Person
    {
        private string firstName;
        private string lastName;
        
        public Person(string lName, string fName)
        {
            LastName = lName;
            FirstName = fName;
        }

        public string FirstName 
        {
            get 
            {
                return firstName;
            }
            set 
            {
                value = firstName;
            } 
        }
        public string LastName 
        {
            get
            {
                return lastName;
            }
            set
            {
                value = lastName;
            }
        }
    }
}
