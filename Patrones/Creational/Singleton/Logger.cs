using System;
using System.IO;

// Clase Singleton Logger para registrar mensajes en un archivo de registro
public sealed class Logger
{
    private static readonly Logger instance = new Logger();
    private string logFilePath;

    // Constructor privado para evitar la creación de instancias desde fuera de la clase
    private Logger()
    {
        logFilePath = "log.txt";
    }

    // Propiedad estática para acceder a la única instancia
    public static Logger Instance
    {
        get { return instance; }
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
