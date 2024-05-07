using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPatrones
{
    internal interface ISpaState
    {
        void HandleReservation(SpaService spaService, string roomNumber, DateTime dateTime, int duration);
    }
}
