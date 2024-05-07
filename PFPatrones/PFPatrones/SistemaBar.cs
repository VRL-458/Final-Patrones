using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFPatrones
{
    internal class SistemaBar : IObserver, IElement
    {
        public void Update(string message)
        {
            // Lógica para atender la solicitud de bebida
            Console.WriteLine("Sistema de Bar: " + message);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
