using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFPatrones
{
    internal class SistemaLimpieza : IObserver, IElement
    {
        public void Update(string message)
        {
            // Lógica para atender la solicitud de limpieza
            Console.WriteLine("Sistema de Limpieza: " + message);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
