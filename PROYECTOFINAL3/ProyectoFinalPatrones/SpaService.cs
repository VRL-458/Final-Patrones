using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPatrones
{
    internal class SpaService : IElement
    {
        static Random random = new Random();
        private Dictionary<DateTime, List<string>> reservations = new Dictionary<DateTime, List<string>>();
        public Dictionary<string, int> UsageCount { get; private set; } = new Dictionary<string, int>();


        private ISpaState currentState;

        public SpaService()
        {
            //random 
            
        }

        public void SetState(ISpaState newState)
        {
            currentState = newState;
        }

        public void RequestReservation(string roomNumber, DateTime dateTime, int duration)
        {
            aleatorioStado();
            currentState.HandleReservation(this, roomNumber, dateTime, duration);

            if (!UsageCount.ContainsKey(roomNumber))
                UsageCount[roomNumber] = 0;
            if (currentState is DisponibleState)
                UsageCount[roomNumber]++;
        }

        public void AddReservation(string roomNumber, DateTime dateTime, int duration)
        {
            // Logic to add reservation
            if (!reservations.ContainsKey(dateTime))
            {
                reservations[dateTime] = new List<string>();
            }
            reservations[dateTime].Add(roomNumber);
        }

        public bool HasSpaceForSecondaryReservation(DateTime dateTime, int duration)
        {
            // Simplified logic to check for space
            return reservations.ContainsKey(dateTime) && reservations[dateTime].Count == 1;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }


        public void aleatorioStado()
        {
           
            switch (random.Next(3)) // Genera un número aleatorio entre 0 y 2
            {
                case 0:
                    currentState = new DisponibleState();
                    Console.WriteLine("Estado inicial del Spa: Disponible");
                    break;
                case 1:
                    currentState = new ReservadoState();
                    Console.WriteLine("Estado inicial del Spa: Reservado");
                    break;
                case 2:
                    currentState = new NoDisponibleState();
                    Console.WriteLine("Estado inicial del Spa: No Disponible");
                    break;
                
            }

        }
    }
}
