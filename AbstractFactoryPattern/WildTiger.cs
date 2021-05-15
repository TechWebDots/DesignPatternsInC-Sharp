using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.AbstractFactoryPattern
{
    class WildTiger : ITiger
    {
        public HttpResponse _response => new HttpContextAccessor().HttpContext.Response;
        public void Speak()
        {
            _response.WriteAsync("Wild Tiger says: Halum.\n\n");
        }
        public void Action()
        {
            _response.WriteAsync("Wild Tigers prefer hunting in jungles.\n\n");
        }
    }
}
