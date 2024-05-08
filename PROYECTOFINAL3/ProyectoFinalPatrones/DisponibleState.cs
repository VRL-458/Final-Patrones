using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPatrones
{
    internal class DisponibleState : ISpaState
    {
        public void HandleReservation(SpaService spaService, string roomNumber, DateTime dateTime, int duration)
        {
            spaService.AddReservation(roomNumber, dateTime, duration);
            Console.WriteLine("Reservación confirmada para la habitación " + roomNumber + " el " + dateTime.ToString("yyyy-MM-dd HH:mm"));
        }
    }
}
