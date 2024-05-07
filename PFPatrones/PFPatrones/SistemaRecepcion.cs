using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFPatrones
{
    internal class SistemaRecepcion
    {
        private Subject subject;

        public SistemaRecepcion()
        {
            subject = new Subject();

            // Adjuntar los sistemas a la lista de observadores
            subject.Attach(new SistemaMantenimiento());
            subject.Attach(new SistemaLimpieza());
            subject.Attach(new SistemaCocina());
            subject.Attach(new SistemaBar());
        }

        public void RecibirSolicitud(int numeroHabitacion, string descripcion)
        {
            string mensaje = "Habitación " + numeroHabitacion + ": " + descripcion;
            subject.NotifyObservers(mensaje);
        }

        public void SolicitarReservaSpa(int numeroHabitacion, string fechaHora)
        {
            SistemaSpa sistemaSpa = new SistemaSpa(EstadoSpa.Disponible); // Cambiar el estado según corresponda
            sistemaSpa.SolicitarReserva(numeroHabitacion, fechaHora);
        }
    }
}
