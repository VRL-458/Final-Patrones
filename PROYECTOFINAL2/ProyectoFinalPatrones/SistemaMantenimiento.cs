using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPatrones
{
    internal class SistemaMantenimiento : IObserver
    {
        public void Update(string message)
        {
            if (message.Contains("incidente"))
            {
                Console.WriteLine($"Mantenimiento respondiendo a: {message}");
                // Lógica para enviar personal de mantenimiento
            }
        }
    }
}
