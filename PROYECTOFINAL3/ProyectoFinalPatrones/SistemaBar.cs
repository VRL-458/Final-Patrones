using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPatrones
{
    internal class SistemaBar : IObserver, IElement
    {
        public Dictionary<string, int> UsageCount { get; private set; } = new Dictionary<string, int>();


        public void Update(string message)
        {
            if (message.Contains("bebida"))
            {
                Console.WriteLine($"Bar sirviendo: {message}");
                // Lógica para preparar y servir bebidas
                string room = message.Split(' ')[2];
                if (!UsageCount.ContainsKey(room))
                    UsageCount[room] = 0;
                UsageCount[room]++;
            }
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
