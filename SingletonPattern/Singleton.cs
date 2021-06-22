using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.SingletonPattern
{
    public sealed class Singleton
    {
        public HttpResponse _response => new HttpContextAccessor().HttpContext.Response;
        private static Singleton instance;
        private int numberOfInstances = 0;
        //Private constructor is used to prevent creation of instances with 'new' keyword outside this class
        private Singleton()
        {
            _response.WriteAsync("Instantiating inside the private constructor.\n\n");
            numberOfInstances++;
            _response.WriteAsync(string.Format("Number of instances ={0}\n\n", numberOfInstances));
        }
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton(); 
                    
                }
                return instance;
            }
        }

        //Double checked locking
        
    }
    public sealed class SingletonTS
    {
        public HttpResponse _response => new HttpContextAccessor().HttpContext.Response;
        //private static readonly SingletonTS instance=new SingletonTS();
        //We are using volatile to ensure that assignment to the instance variable finishes before it’s access.
        private static volatile SingletonTS instance;
        private static object lockObject = new Object();
        private SingletonTS() { _response.WriteAsync("Instantiating thread-safe inside the private constructor.\n\n"); }
        public static SingletonTS Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                            instance = new SingletonTS();
                    }
                }
                return instance;
            }
        }
    }
}