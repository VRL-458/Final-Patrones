using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPatrones
{
    internal class SpaService : IElement
    {
        private Dictionary<DateTime, List<string>> reservations = new Dictionary<DateTime, List<string>>();
        public Dictionary<string, int> UsageCount { get; private set; } = new Dictionary<string, int>();


        private ISpaState currentState;

        public SpaService()
        {
            currentState = new DisponibleState(); // Estado inicial
        }

        public void SetState(ISpaState newState)
        {
            currentState = newState;
        }

        public void RequestReservation(string roomNumber, DateTime dateTime, int duration)
        {
            currentState.HandleReservation(this, roomNumber, dateTime, duration);

            if (!UsageCount.ContainsKey(roomNumber))
                UsageCount[roomNumber] = 0;
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
    }
}
