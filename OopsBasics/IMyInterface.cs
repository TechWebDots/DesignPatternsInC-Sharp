using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.OopsBasics
{
    interface IMyInterface
    {
        // Interface method
        int GetArea();
        // Interface property
        int Area { get; set; }

        // Interface indexer
        int this[int index] { get; set; }
        // Interface event
        event System.EventHandler MyEvent;
    }

    interface IComparable
    {
        int Compare(object o);
    }

    class OneCircle : IComparable
    {
        int r;
        public int Compare(object o)
        {
            return r - (o as OneCircle).r;
        }        
    }    
}
