using Patrones.Creational.AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Creational.AbstractFactory.Factory
{
    public class CarFactory : IVehicleFactory
    {
        public ICar CreateCar()
        {
            return new Sedan();
        }

        public IMotorcycle CreateMotorcycle()
        {
            // Lanzaremos una excepción para mantener la simplicidad del ejemplo,
            // ya que la fábrica de automóviles no produce motocicletas.
            throw new NotImplementedException("La fábrica de automóviles no produce motocicletas.");
        }
    }
}
