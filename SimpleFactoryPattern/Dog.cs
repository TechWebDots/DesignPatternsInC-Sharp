using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.SimpleFactoryPattern
{
    public class Dog : IAnimal
    {
        public HttpContext _httpContext => new HttpContextAccessor().HttpContext;
        public void Speak()
        {
            _httpContext.Response.WriteAsync("Dog says: Bow-Wow...\n");
        }
        public void Action()
        {
            _httpContext.Response.WriteAsync("Dogs prefer barking...\n\n");
        }
    }
}
