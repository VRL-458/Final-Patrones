using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFPatrones
{
    internal class SistemaMantenimiento : IObserver , IElement
    {
        public void Update(string message)
        {
            // Lógica para atender la solicitud de mantenimiento
            Console.WriteLine("Sistema de Mantenimiento: " + message);

        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

}
