using Patrones.Structural.DecoratorPattern.Interface;

namespace Patrones.Structural.DecoratorPattern
{
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IComponent component) : base(component)
        {
        }

        public override string Operation()
        {
            string addedBehavior = "ConcreteDecoratorB";
            return base.Operation() + " + " + addedBehavior;
        }
    }
}
