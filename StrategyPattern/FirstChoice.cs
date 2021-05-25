using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.StrategyPattern
{
    public class FirstChoice : IChoice
    {
        HttpContext _httpContext => new HttpContextAccessor().HttpContext;
        public void MyChoice()
        {
            _httpContext.Response.WriteAsync("Traveling to Japan\n");
        }
    }
}
