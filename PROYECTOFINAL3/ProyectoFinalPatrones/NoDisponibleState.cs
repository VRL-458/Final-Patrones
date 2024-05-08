using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPatrones
{
    internal class NoDisponibleState : ISpaState
    {
        public void HandleReservation(SpaService spaService, string roomNumber, DateTime dateTime, int duration)
        {
            Console.WriteLine("Servicio no disponible para la fecha y hora especificadas.");
        }
    }
}
