using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPatrones
{
    internal class SistemaCocina : IObserver
    {
        public void Update(string message)
        {
            if (message.Contains("comida"))
            {
                Console.WriteLine($"Cocina preparando: {message}");
                // Lógica para preparar y enviar comida
            }
        }
    }
}
