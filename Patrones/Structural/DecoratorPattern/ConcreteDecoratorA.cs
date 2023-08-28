using Patrones.Structural.DecoratorPattern.Interface;

namespace Patrones.Structural.DecoratorPattern
{
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(IComponent component) : base(component)
        {
        }

        public override string Operation()
        {
            string addedBehavior = "ConcreteDecoratorA";
            return base.Operation() + " + " + addedBehavior;
        }
    }
}
