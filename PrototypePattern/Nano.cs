using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.PrototypePattern
{
    public class Nano:BasicCar
    {
        public Nano(string m)
        {
            ModelName = m;
        }
        public override BasicCar Clone()
        {
            //creates a shallow copy of the current object
            return (Nano)this.MemberwiseClone();
        }
    }
}
