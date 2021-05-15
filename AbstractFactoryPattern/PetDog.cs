using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.AbstractFactoryPattern
{
    class PetDog : IDog
    {
        public HttpResponse _response => new HttpContextAccessor().HttpContext.Response;
        public void Speak()
        {
            _response.WriteAsync("Pet Dog says: Bow-Wow.\n\n");
        }
        public void Action()
        {
            _response.WriteAsync("Pet Dogs prefer to stay at home.\n\n");
        }
    }
}
