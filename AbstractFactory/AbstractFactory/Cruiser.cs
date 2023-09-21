using Patrones.Creational.AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Creational.AbstractFactory
{
    public class Cruiser : IMotorcycle
    {
        public void Manufacture()
        {
            Console.WriteLine("Fabricando una motocicleta Cruiser.");
        }
    }
}
