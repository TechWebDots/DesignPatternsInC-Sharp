using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.ObserverPattern
{
    interface ISubject
    {
        void Register(IObserver o);
        void Unregister(IObserver o);
        void NotifyRegisteredUsers(int i);
    }
}
