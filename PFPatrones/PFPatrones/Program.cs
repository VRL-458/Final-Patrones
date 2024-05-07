using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFPatrones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SistemaRecepcion sistemaRecepcion = new SistemaRecepcion();
            VisitorReporteStdr visitor = new VisitorReporteStdr();

            string continuar = "y";

            while (continuar == "y")
            {
                Console.WriteLine("\nOpciones:");
                Console.WriteLine("1. Recibir solicitud de huésped");
                Console.WriteLine("2. Solicitar reserva de Spa");
                Console.WriteLine("3. Generar reportes");
                Console.Write("Ingrese una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el número de habitación: ");
                        int numeroHabitacion = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la descripción de la solicitud: ");
                        string descripcion = Console.ReadLine();
                        sistemaRecepcion.RecibirSolicitud(numeroHabitacion, descripcion);
                        break;
                    case "2":
                        Console.Write("Ingrese el número de habitación: ");
                        numeroHabitacion = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la fecha y hora de la reserva: ");
                        string fechaHora = Console.ReadLine();
                        sistemaRecepcion.SolicitarReservaSpa(numeroHabitacion, fechaHora);
                        break;
                    case "3":
                        SistemaMantenimiento sistemaMantenimiento = new SistemaMantenimiento();
                        SistemaLimpieza sistemaLimpieza = new SistemaLimpieza();
                        SistemaCocina sistemaCocina = new SistemaCocina();
                        SistemaBar sistemaBar = new SistemaBar();
                        SistemaSpa sistemaSpa = new SistemaSpa(EstadoSpa.Disponible);

                        sistemaMantenimiento.Accept(visitor);
                        sistemaLimpieza.Accept(visitor);
                        sistemaCocina.Accept(visitor);
                        sistemaBar.Accept(visitor);
                        sistemaSpa.Accept(visitor);
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.Write("\n¿Desea continuar? (y/n): ");
                continuar = Console.ReadLine().ToLower();

            }
        }
    }
}
