using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.AdapterPattern
{
    public class Triangle: ITriangle
    {
        HttpContext _httpContext => new HttpContextAccessor().HttpContext;
        public double BaseLength;//base
        public double Height;//height
        public Triangle(double b, double h)
        {
            this.BaseLength = b;
            this.Height = h;
        }
        public double CalculateAreaOfTriangle()
        {
            return 0.5 * BaseLength * Height;
        }
        public void AboutTriangle()
        {
            _httpContext.Response.WriteAsync("\nActually, I am a Triangle\n");
        }
    }
}
