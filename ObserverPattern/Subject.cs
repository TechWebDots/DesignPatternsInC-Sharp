using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.ObserverPattern
{
    public class Subject: ISubject
    {
        List<IObserver> observerList = new List<IObserver>();
        private int flag;
        public int Flag
        {
            get
            {
                return flag;
            }
            set
            {
                flag = value;
                //Flag value changed. So notify observer/s.
                NotifyRegisteredUsers(flag);
            }
        }
        public void Register(IObserver anObserver)
        {
            observerList.Add(anObserver);
        }
        public void Unregister(IObserver anObserver)
        {
            observerList.Remove(anObserver);
        }
        public void NotifyRegisteredUsers(int i)
        {
            foreach (IObserver observer in observerList)
            {
                observer.Update(i);
            }
        }
    }
}