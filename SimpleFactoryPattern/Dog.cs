using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.SimpleFactoryPattern
{
    public class Dog : IAnimal
    {
        public void Speak(HttpContext httpContext)
        {
            HttpResponseWritingExtensions.WriteAsync(httpContext.Response, "Dog says: Bow-Wow...\n");
        }
        public void Action(HttpContext httpContext)
        {
            HttpResponseWritingExtensions.WriteAsync(httpContext.Response, "Dogs prefer barking...\n");
        }
    }
}
