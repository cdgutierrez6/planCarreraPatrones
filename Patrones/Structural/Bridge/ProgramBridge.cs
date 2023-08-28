using Patrones.Structural.Bridge.Abstracts;
using Patrones.Structural.Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Structural.Bridge
{
    public class ProgramBridge
    {
        static void Main(string[] args)
        {
            IImplementation implementationA = new ConcreteImplementationA();
            IImplementation implementationB = new ConcreteImplementationB();

            Abstraction abstractionA = new RefinedAbstraction(implementationA);
            Abstraction abstractionB = new RefinedAbstraction(implementationB);

            abstractionA.Operation();
            abstractionB.Operation();
        }
    }
}
