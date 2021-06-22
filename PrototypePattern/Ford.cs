using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.PrototypePattern
{
    public class Ford:BasicCar
    {
        public Ford(string m)
        {
            ModelName = m;
        }
        public override BasicCar Clone()
        {
            //creates a shallow copy of the current object
            return (Ford)this.MemberwiseClone();
        }
    }
}
