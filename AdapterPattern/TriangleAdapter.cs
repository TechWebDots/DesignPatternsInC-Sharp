using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.AdapterPattern
{
    public class TriangleAdapter:IRect
    {
        Triangle triangle;
        public TriangleAdapter(Triangle t)
        {
            this.triangle = t;
        }
        public void AboutRectangle()
        {
            triangle.AboutTriangle();
        }
        public double CalculateAreaOfRectangle()
        {
            return triangle.CalculateAreaOfTriangle();
        }
    }
}

