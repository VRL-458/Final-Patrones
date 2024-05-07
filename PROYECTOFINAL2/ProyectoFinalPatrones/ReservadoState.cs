using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPatrones
{
    internal class ReservadoState : ISpaState
    {
        public void HandleReservation(SpaService spaService, string roomNumber, DateTime dateTime, int duration)
        {
            if (spaService.HasSpaceForSecondaryReservation(dateTime, duration))
            {
                Console.WriteLine("Reservación en espera. Se confirmará 30 minutos antes.");
            }
            else
            {
                Console.WriteLine("Reservación no disponible en este horario.");
                spaService.SetState(new NoDisponibleState());
            }
        }
    }
}
