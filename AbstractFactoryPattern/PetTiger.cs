using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.AbstractFactoryPattern
{
    class PetTiger : ITiger
    {
        public HttpResponse _response => new HttpContextAccessor().HttpContext.Response;
        public void Speak()
        {
            _response.WriteAsync("Pet Tiger says: Halum.\n\n");
        }
        public void Action()
        {
            _response.WriteAsync("Pet Tigers play in an animal circus.\n\n");
        }
    }
}
