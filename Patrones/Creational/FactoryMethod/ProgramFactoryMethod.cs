using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Creational.FactoryMethod
{
    public class ProgramFactoryMethod
    {
        static void MainFactoryMethod(string[] args)
        {
            Console.WriteLine("Fabrica de Productos Electrónicos - Factory Method");

            // Creamos una fábrica de teléfonos
            IElectronicFactory phoneFactory = new PhoneFactory();
            IElectronicProduct phone = phoneFactory.CreateProduct();
            phone.Display();

            Console.WriteLine();

            // Creamos una fábrica de laptops
            IElectronicFactory laptopFactory = new LaptopFactory();
            IElectronicProduct laptop = laptopFactory.CreateProduct();
            laptop.Display();
        }
    }
}
