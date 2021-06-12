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

            //local variable
            int counter = 0;
        }
                
        //properties
        public string Colour
        {
            get => colour;
            set => colour = value;
        }
        public string YoM
        {
            get => yoM;
            set => yoM = value;
        }

        //methods
        public void Start()
        {
            //local variable
            int counter = 0;
            Console.WriteLine("Car Start!");
        }
        public void Stop()
        {
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
