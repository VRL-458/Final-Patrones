using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFPatrones
{
    internal class SistemaCocina : IObserver, IElement
    {
        public void Update(string message)
        {
            // Lógica para atender la solicitud de comida
            Console.WriteLine("Sistema de Cocina: " + message);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
