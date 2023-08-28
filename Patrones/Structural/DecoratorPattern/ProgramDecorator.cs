using Patrones.Structural.DecoratorPattern.Interface;

namespace Patrones.Structural.DecoratorPattern
{
    public class ProgramDecorator
    {
        static void Main(string[] args)
        {
            // Componente concreto
            IComponent component = new ConcreteComponent();

            // Decoradores
            IComponent decoratorA = new ConcreteDecoratorA(component);
            IComponent decoratorB = new ConcreteDecoratorB(decoratorA);

            // Mostrar resultados
            Console.WriteLine("Component: " + component.Operation());
            Console.WriteLine("Decorator A: " + decoratorA.Operation());
            Console.WriteLine("Decorator B: " + decoratorB.Operation());
        }
    }
}
