using Patrones.Structural.Bridge.Interface;

namespace Patrones.Structural.Bridge
{
    public class ConcreteImplementationA : IImplementation
    {
        public void OperationImplementation()
        {
            Console.WriteLine("Concrete Implementation A");
        }
    }
}
