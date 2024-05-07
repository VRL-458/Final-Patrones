using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFPatrones
{

    public enum EstadoSpa
    {
        Reservado,
        Disponible,
        NoDisponible
    }
    internal class SistemaSpa : IElement
    {
        private EstadoSpa estado;

        public SistemaSpa(EstadoSpa estado)
        {
            this.estado = estado;
        }

        public void SolicitarReserva(int numeroHabitacion, string fechaHora)
        {
            switch (estado)
            {
                case EstadoSpa.Reservado:
                    Console.WriteLine("Solicitud de reserva recibida. Se notificará si se hace efectiva.");
                    break;
                case EstadoSpa.Disponible:
                    Console.WriteLine("Reserva confirmada para la habitación " + numeroHabitacion + " en la fecha/hora " + fechaHora);
                    break;
                case EstadoSpa.NoDisponible:
                    Console.WriteLine("El servicio de Spa no está disponible en ese horario.");
                    break;
            }
        }


        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
