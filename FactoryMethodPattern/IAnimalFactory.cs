using DesignPatternsInC_Sharp.SimpleFactoryPattern;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.FactoryMethodPattern
{
    public abstract class IAnimalFactory
    {
        public HttpContext _httpContext => new HttpContextAccessor().HttpContext;
        public IAnimal MakeAnimal()
        {
            _httpContext.Response.WriteAsync("IAnimalFactory.MakeAnimal()-You cannot ignore parent rules.\n\n");            
            /*At this point, it doesn't know whether it will get a Dog or a Tiger. It will be decided by the subclasses
            i.e.DogFactory or TigerFactory. But it knows that it will Speak and it will have a preferred way of Action.
            */
            IAnimal animal = CreateAnimal();
            animal.Speak();
            animal.Action();
            return animal;
        }
        //So, the following method is acting like a factory(of creation).
        public abstract IAnimal CreateAnimal();
    }
}
