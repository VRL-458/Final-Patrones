using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPatrones
{
    internal class ReportVisitor : IVisitor // mantenimietno vale 100, limpieza 200, cocina 300 ...
    {
        public void Visit(SistemaMantenimiento sistema)
        {
            Console.WriteLine("Reporte de Mantenimiento:");
            foreach (var entry in sistema.UsageCount)
            {
                Console.WriteLine($"Habitación {entry.Key}: {entry.Value} servicios. Costo generado {entry.Value * 100}");
            }
        }

        public void Visit(SistemaLimpieza sistemaLimpieza)
        {
            Console.WriteLine("Reporte de Limpieza:");
            foreach (var entry in sistemaLimpieza.UsageCount)
            {
                Console.WriteLine($"Habitación {entry.Key}: {entry.Value} servicios. Costo generado {entry.Value * 200}");
            }
        }

        public void Visit(SistemaCocina sistemaCocina)
        {
            Console.WriteLine("Reporte de Cocina:");
            foreach (var entry in sistemaCocina.UsageCount)
            {
                Console.WriteLine($"Habitación {entry.Key}: {entry.Value} servicios. Costo generado {entry.Value * 300}");
            }
        }

        public void Visit(SistemaBar sistemaBar)
        {
            Console.WriteLine("Reporte de Bar:");
            foreach (var entry in sistemaBar.UsageCount)
            {
                Console.WriteLine($"Habitación {entry.Key}: {entry.Value} servicios. Costo generado {entry.Value * 400}");
            }
        }

        public void Visit(SpaService spaService)
        {
            Console.WriteLine("Reporte de Spa Service:");
            foreach (var entry in spaService.UsageCount)
            {
                Console.WriteLine($"Habitación {entry.Key}: {entry.Value} servicios. Costo generado {entry.Value * 500}");
            }
        }
    }
}
