using Patrones.Structural.DecoratorPattern.Interface;

namespace Patrones.Structural.DecoratorPattern
{
    public class ConcreteComponent : IComponent
    {
        public string Operation()
        {
            return "ConcreteComponent";
        }
    }
}
