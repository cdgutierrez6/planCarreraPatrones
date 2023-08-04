using System;
using System.IO;

// Clase Singleton Logger para registrar mensajes en un archivo de registro
public sealed class Logger
{
    private static Logger instance;
    private static readonly object lockObject = new object();
    private string logFilePath;


    // Constructor privado para evitar la creación de instancias desde fuera de la clase
    private Logger()
    {
        logFilePath = "log.txt";
    }

    // Propiedad estática para acceder a la única instancia
    // Método estático para obtener la instancia única
    public static Logger GetInstance()
    {
        if (instance == null)
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
            }
        }

        return instance;
    }

    // Método para registrar un mensaje en el archivo de registro
    public void LogMessage(string message)
    {
        try
        {
            using (StreamWriter sw = File.AppendText(logFilePath))
            {
                sw.WriteLine($"{DateTime.Now}: {message}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al escribir en el archivo de registro: {ex.Message}");
        }
    }
}
