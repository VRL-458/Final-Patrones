using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFPatrones
{
    internal class VisitorReporteStdr : IVisitor
    {
        public void Visit(SistemaMantenimiento sistemaMantenimiento)
        {
            // Lógica para generar el reporte del sistema de mantenimiento
            Console.WriteLine("Generando reporte del sistema de mantenimiento...");
        }

        public void Visit(SistemaLimpieza sistemaLimpieza)
        {
            // Lógica para generar el reporte del sistema de limpieza
            Console.WriteLine("Generando reporte del sistema de limpieza...");
        }

        // Implementación de los demás métodos Visit() para los otros sistemas
        public void Visit(SistemaCocina sistemaCocina) { }
        public void Visit(SistemaBar sistemaBar) { }
        public void Visit(SistemaSpa sistemaSpa) { }
    }
}
