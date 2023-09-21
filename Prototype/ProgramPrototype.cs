using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class ProgramPrototype
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototipo - Clonación de empleados");

            Developer originalDeveloper = new Developer()
            {
                Name = "John Doe",
                Age = 30,
                Language = "C#"
            };

            Developer clonedDeveloper = (Developer)originalDeveloper.Clone();
            clonedDeveloper.Name = "Jane Smith"; // Modificamos el nombre del empleado clonado

            Manager originalManager = new Manager()
            {
                Name = "Alex Johnson",
                Age = 40,
                Department = "HR"
            };

            Manager clonedManager = (Manager)originalManager.Clone();
            clonedManager.Name = "Michael Brown"; // Modificamos el nombre del empleado clonado

            Console.WriteLine("Detalles del desarrollador original:");
            DisplayEmployeeDetails(originalDeveloper);

            Console.WriteLine("\nDetalles del desarrollador clonado:");
            DisplayEmployeeDetails(clonedDeveloper);

            Console.WriteLine("\nDetalles del gerente original:");
            DisplayEmployeeDetails(originalManager);

            Console.WriteLine("\nDetalles del gerente clonado:");
            DisplayEmployeeDetails(clonedManager);
        }

        static void DisplayEmployeeDetails(Employee employee)
        {
            Console.WriteLine($"Nombre: {employee.Name}, Edad: {employee.Age}");
            if (employee is Developer developer)
            {
                Console.WriteLine($"Tipo: Desarrollador, Lenguaje: {developer.Language}");
            }
            else if (employee is Manager manager)
            {
                Console.WriteLine($"Tipo: Gerente, Departamento: {manager.Department}");
            }
        }
    }
}
