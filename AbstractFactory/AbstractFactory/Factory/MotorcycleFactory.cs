using Patrones.Creational.AbstractFactory.Interface;

namespace Patrones.Creational.AbstractFactory.Factory
{
    public class MotorcycleFactory : IVehicleFactory
    {
        public ICar CreateCar()
        {
            // Lanzaremos una excepción para mantener la simplicidad del ejemplo,
            // ya que la fábrica de motocicletas no produce automóviles.
            throw new NotImplementedException("La fábrica de motocicletas no produce automóviles.");
        }

        public IMotorcycle CreateMotorcycle()
        {
            return new Cruiser();
        }
    }
}
