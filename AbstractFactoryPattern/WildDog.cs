using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.AbstractFactoryPattern
{
    class WildDog : IDog
    {
        public HttpResponse _response => new HttpContextAccessor().HttpContext.Response;
        public void Speak()
        {
            _response.WriteAsync("Wild Dog says: Bow-Wow.\n\n");
        }
        public void Action()
        {
            _response.WriteAsync("Wild Dogs prefer to roam freely in jungles.\n\n");
        }
    }
}
