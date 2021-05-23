using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.ObserverPattern
{
    public class ObserverType2:IObserver
    {
        HttpContext _httpContext => new HttpContextAccessor().HttpContext;
        string nameOfObserver;
        public ObserverType2(String name)
        {
            this.nameOfObserver = name;
        }
        public void Update(int i)
        {
            _httpContext.Response.WriteAsync(string.Format("{0} notified: DB flag Value in Subject at present: {1} \n", nameOfObserver, i));
        }
    }
}
