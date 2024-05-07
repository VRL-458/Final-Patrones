using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPatrones
{
    internal class SistemaLimpieza : IObserver
    {
        public void Update(string message)
        {
            if (message.Contains("limpieza"))
            {
                Console.WriteLine($"Limpieza respondiendo a: {message}");
                // Lógica para enviar personal de limpieza
            }
        }
    }
}
