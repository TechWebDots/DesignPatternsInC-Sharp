using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.SimpleFactoryPattern
{
    public class Tiger : IAnimal
    {
        public HttpContext _httpContext => new HttpContextAccessor().HttpContext;
        public void Speak()
        {
            _httpContext.Response.WriteAsync("Tiger says: Halum...\n");
        }
        public void Action()
        {
            _httpContext.Response.WriteAsync("Tigers prefer hunting...\n\n");
        }
    }
}
