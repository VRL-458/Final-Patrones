using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPatrones
{
    internal interface IVisitor
    {
        void Visit(SistemaMantenimiento sistemaMantenimiento);
        void Visit(SistemaLimpieza sistemaLimpieza);
        void Visit(SistemaCocina sistemaCocina);
        void Visit(SistemaBar sistemaBar);
        void Visit(SpaService spaService);
    }
}
