using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPatrones
{
    internal class SistemaBar : IObserver
    {
        public void Update(string message)
        {
            if (message.Contains("bebida"))
            {
                Console.WriteLine($"Bar sirviendo: {message}");
                // Lógica para preparar y servir bebidas
            }
        }
    }
}
