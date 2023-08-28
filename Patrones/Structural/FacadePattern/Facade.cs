using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Structural.FacadePattern
{
    public class Facade
    {
        private SubsystemA _subsystemA;
        private SubsystemB _subsystemB;
        private SubsystemC _subsystemC;

        public Facade()
        {
            _subsystemA = new SubsystemA();
            _subsystemB = new SubsystemB();
            _subsystemC = new SubsystemC();
        }

        public void Operation1()
        {
            Console.WriteLine("Facade - Operation 1");
            _subsystemA.MethodA();
            _subsystemB.MethodB();
        }

        public void Operation2()
        {
            Console.WriteLine("Facade - Operation 2");
            _subsystemB.MethodB();
            _subsystemC.MethodC();
        }
    }
}
