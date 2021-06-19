using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.BuilderPattern
{
    // Builders common interface
    interface IBuilder
    {
        void StartUpOperations();
        void BuildBody();
        void InsertWheels();
        void AddHeadlights();
        void EndOperations();
        Product GetVehicle();
    }
}
