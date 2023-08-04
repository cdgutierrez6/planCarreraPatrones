using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Creational.Singleton
{
    public class ProgramSingleton
    {
        static void MainSingleton(string[] args)
        {
            Console.WriteLine("Uso del Singleton Logger");

            // Obtenemos la instancia única del Logger
            Logger logger = Logger.Instance;

            // Registramos algunos mensajes
            logger.LogMessage("Inicio del programa");
            logger.LogMessage("Algunos mensajes de prueba");
            logger.LogMessage("Finalización del programa");
        }
    }
}
