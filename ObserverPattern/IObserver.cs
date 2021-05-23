using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.ObserverPattern
{
    public interface IObserver
    {
        void Update(int i);
    }
}
