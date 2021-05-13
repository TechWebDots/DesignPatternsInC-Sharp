using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.SimpleFactoryPattern
{
    public class Tiger : IAnimal
    {
        public void Speak(HttpContext httpContext)
        {
            HttpResponseWritingExtensions.WriteAsync(httpContext.Response, "Tiger says: Halum...\n");
        }
        public void Action(HttpContext httpContext)
        {
            HttpResponseWritingExtensions.WriteAsync(httpContext.Response, "Tigers prefer hunting...\n");
        }
    }
}
