using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.BridgePattern
{
    public class Television : ElectronicGoods
    {
        HttpContext _httpContext => new HttpContextAccessor().HttpContext;        
        /*Implementation specific: We are delegating the implementation to the Implementor object*/
        public override void MoveToCurrentState()
        {
            _httpContext.Response.WriteAsync("\nTelevision is functioning at : ");
            state.MoveState();
        }
    }
}
