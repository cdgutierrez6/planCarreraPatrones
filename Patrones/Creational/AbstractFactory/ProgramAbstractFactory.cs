using Patrones.Creational.AbstractFactory.Factory;
using Patrones.Creational.AbstractFactory.Interface;
using Patrones.Creational.AbstractFactory;

class ProgramAbstractFactory
{
    static void MainAbstractFactory(string[] args)
    {
        Console.WriteLine("Fabrica de Vehículos - Abstract Factory");

        // Creamos una fábrica de automóviles
        IVehicleFactory carFactory = new CarFactory();
        Client carClient = new Client(carFactory);
        carClient.Run();

        Console.WriteLine();

        // Creamos una fábrica de motocicletas
        IVehicleFactory motorcycleFactory = new MotorcycleFactory();
        Client motorcycleClient = new Client(motorcycleFactory);
        motorcycleClient.Run();
    }
}
