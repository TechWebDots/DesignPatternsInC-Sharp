using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.BridgePattern
{
    public class OnState : IState
    {
        HttpContext _httpContext => new HttpContextAccessor().HttpContext;
        public void MoveState()
        {
            _httpContext.Response.WriteAsync("On State\n");
        }
    }
}
