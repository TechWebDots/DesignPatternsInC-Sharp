using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.BuilderPattern
{
    // "Product"
    class Product
    {
        HttpContext _httpContext => new HttpContextAccessor().HttpContext;
        
        private List<string> parts;
        public Product()
        {
            parts = new List<string>();
        }
        public void Add(string part)
        {
            //Adding parts
            parts.Add(part);
        }
        public void Show()
        {
            _httpContext.Response.WriteAsync("\n\nProduct completed as below :\n");
            _httpContext.Response.WriteAsync("********************************\n");
            foreach (string part in parts)
                _httpContext.Response.WriteAsync(part+"\n");
        }
    }
}
