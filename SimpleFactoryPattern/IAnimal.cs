using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.SimpleFactoryPattern
{
    public interface IAnimal
    {
        void Speak();
        void Action();
    }
}
