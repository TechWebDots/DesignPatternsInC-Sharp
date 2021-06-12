using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.OopsBasics
{
    abstract class Shape
    {
        internal int x = 100, y = 100;
        public abstract int GetArea();    
        //// Abstract property
        //public abstract int area { get; set; }
        //// Abstract indexer
        //public abstract int this[int index] { get; set; }
        //// Abstract event
        //public delegate void MyDelegate();
        //public abstract event MyDelegate MyEvent;
        //// Abstract class
        //public abstract class InnerShape { };
    }
    class Rectangle : Shape
    {
        public override int GetArea() { return x * y; }
    }

    abstract class Circle : Shape
    {
        private int x = 100, y = 100;
        public int GetOtherArea() { return x * y; }
    }

    abstract class Triangle : Shape
    {
        public override int GetArea() { return x * y; }
    }    

    abstract class Sphere : Shape
    {
        //you apply sealed
        public sealed override int GetArea()
        {
            //new implementation
            return 1*1;
        }
    }


}
