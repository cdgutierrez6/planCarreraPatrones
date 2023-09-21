using Patrones.Creational.AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Creational.AbstractFactory
{
    public class Client
    {
        private ICar car;
        private IMotorcycle motorcycle;

        public Client(IVehicleFactory factory)
        {
            car = factory.CreateCar();
            motorcycle = factory.CreateMotorcycle();
        }

        public void Run()
        {
            Console.WriteLine("Produciendo vehículos...");
            car.Manufacture();
            motorcycle.Manufacture();
        }
    }
}
