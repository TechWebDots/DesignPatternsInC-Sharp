using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.BridgePattern
{
    public abstract class ElectronicGoods
    {
        //Composition - implementor
        protected IState state;
        //Alternative approach to properties:we can also pass an implementor (as input argument) inside a constructor.
        
        public IState State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        abstract public void MoveToCurrentState();
    }
}
