using Patrones.Structural.Bridge.Interface;

namespace Patrones.Structural.Bridge
{
    public class ConcreteImplementationB : IImplementation
    {
        public void OperationImplementation()
        {
            Console.WriteLine("Concrete Implementation B");
        }
    }

}
