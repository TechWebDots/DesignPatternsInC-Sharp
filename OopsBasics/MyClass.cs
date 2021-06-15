using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.OopsBasics
{
    public class Car:ICar
    {
        //fields
        private string colour;
        private string yoM;
        //constructor
        public Car()
        {
            Colour = "Red";
            YoM = "2021";
        }                
        //properties
        public string Colour
        {
            get{
                return colour;
            }
            set{
                value = colour;
            }
        }
        public string YoM
        {
            get
            {
                return yoM;
            }
            set
            {
                value = yoM;
            }
        }
        //methods
        public void Start()
        {
            //local variable
            string c = colour;
            Console.WriteLine("Car Start!");
        }
        public void Stop()
        {
            string y = yoM;
            Console.WriteLine("Car Stop!");
        }
    }

    static class SampleClass
    {
        //instance member/field/varible
        //int a;
        static int a = 0;
        //static constructor
        static SampleClass()
        {
            //local variable
            int a;
            Car Toyota = new Car();            
            Child myChild = new Child("pablo", "nina");
            IComparable oneCircle = new OneCircle();
        }
        
        //static method
        static string Test()
        {
            //local variable
            string  testVar = string.Empty;
            return testVar;
        }
    }   
}
