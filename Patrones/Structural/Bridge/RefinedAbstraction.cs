using Patrones.Structural.Bridge.Abstracts;
using Patrones.Structural.Bridge.Interface;

namespace Patrones.Structural.Bridge
{
    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(IImplementation implementation) : base(implementation)
        {
        }

        public override void Operation()
        {
            _implementation.OperationImplementation();
        }
    }
}
