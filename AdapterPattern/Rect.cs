using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.AdapterPattern
{
    public class Rect: IRect
    {
        HttpContext _httpContext => new HttpContextAccessor().HttpContext;
        public double Length;
        public double Width;
        public Rect(double l, double w)
        {
            this.Length = l;
            this.Width = w;
        }
        public double CalculateAreaOfRectangle()
        {
            return Length * Width;
        }
        public void AboutRectangle()
        {
            _httpContext.Response.WriteAsync("\nActually, I am a Rectangle\n");
        }
    }
}
