using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.BridgePattern
{
    public class OffState : IState
    {

        HttpContext _httpContext => new HttpContextAccessor().HttpContext;
        public void MoveState()
        {
            _httpContext.Response.WriteAsync("Off State\n");
        }
    }
}
