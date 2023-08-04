using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Creational.AbstractFactory
{
    public class Sedan: ICar
    {
        public void Manufacture()
        {
            Console.WriteLine("Fabricando un automóvil Sedán.");
        }
    }
}
