using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFPatrones
{
    internal abstract class Element : Subject, IElement
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer) => _observers.Add(observer);
        public void Detach(IObserver observer) => _observers.Remove(observer);
        public void Notify(string message)
        {
            foreach (var observer in _observers)
                observer.Update(message);
        }

        public abstract void Accept(IVisitor visitor);
    }
}
