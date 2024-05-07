using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPatrones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var recepcion = new SistemaRecepcion();
            var spaService = new SpaService();
            recepcion.RegisterObserver(new SistemaMantenimiento());
            recepcion.RegisterObserver(new SistemaLimpieza());
            recepcion.RegisterObserver(new SistemaCocina());
            recepcion.RegisterObserver(new SistemaBar());

            string cont = "y";
            while (cont == "y")
            {
                Console.Clear();
                Console.WriteLine("Menú Principal:");
                Console.WriteLine("1. Solicitar Servicio (incidente,bebida,limpieza,comida)");
                Console.WriteLine("2. Reservar Spa");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción (1-3): ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        SolicitarServicio(recepcion);
                        break;
                    case "2":
                        ReservarSpa(spaService);
                        break;
                    case "3":
                        cont = "n";
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente nuevamente.");
                        break;
                }

                if (cont != "n")
                {
                    Console.Write("¿Desea continuar? (y/n): ");
                    cont = Console.ReadLine().ToLower();
                }
            }
        }

        static void SolicitarServicio(SistemaRecepcion recepcion)
        {
            Console.Write("Ingrese la descripción de la solicitud (por ejemplo, 'limpieza en habitación 101'): ");
            string mensaje = Console.ReadLine();
            recepcion.RecibirSolicitud(mensaje);
        }

        static void ReservarSpa(SpaService spaService)
        {
            Console.Write("Ingrese número de habitación: ");
            string roomNumber = Console.ReadLine();

            DateTime dateTime;
            Console.Write("Ingrese fecha y hora de reserva (formato 'yyyy-MM-dd HH:mm'): ");
            while (!DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", null, System.Globalization.DateTimeStyles.None, out dateTime))
            {
                Console.WriteLine("Formato incorrecto, intente nuevamente.");
                Console.Write("Ingrese fecha y hora de reserva (formato 'yyyy-MM-dd HH:mm'): ");
            }

            Console.Write("Ingrese duración en horas: ");
            int duration = int.Parse(Console.ReadLine());  // Simplified, consider using TryParse for production code

            spaService.RequestReservation(roomNumber, dateTime, duration);
        }
    }
    
}
