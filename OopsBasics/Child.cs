using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.OopsBasics
{
    public class Child : Person
    {
        public static int maximumAge;
        public Child(string lastName, string firstName) : 
            base(lastName, firstName) 
        { }
        static Child()
        {            
            maximumAge = 18;
        }

        public string ChildName
        {
            get
            {
                return LastName +" "+ FirstName;
            }
            set
            {
                value = LastName + " " + FirstName; ;
            }
        }
    }
}
