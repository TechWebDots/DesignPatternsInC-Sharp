using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.SimpleFactoryPattern
{
    public class SimpleFactory : ISimpleFactory
    {
        public override IAnimal CreateAnimal(int input)
        {
            IAnimal intendedAnimal = null; 
            switch (input)
            {
                case 0:
                    intendedAnimal = new Dog();
                    break;
                case 1:
                    intendedAnimal = new Tiger();
                    break;
                default:
                    //WriteAsync("Choice must be either 0 or 1");                    
                    //We'll throw a runtime exception for any other choices.
                    throw new ApplicationException(String.Format(" Unknown Animal cannot be instantiated"));
            }
            return intendedAnimal;
        }
    }
}
