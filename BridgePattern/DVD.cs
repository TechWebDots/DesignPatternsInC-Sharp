using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.BridgePattern
{
    public class DVD : ElectronicGoods
    {
        HttpContext _httpContext => new HttpContextAccessor().HttpContext;        
        /*Implementation specific: We are delegating the implementation to the Implementor object*/
        public override void MoveToCurrentState()
        {
            _httpContext.Response.WriteAsync("\nDVD is functioning at : ");
            state.MoveState();
        }
    }
}
