using Patrones.Structural.Flyweight.Factories;
using Patrones.Structural.Flyweight.Interface;

namespace Patrones.Structural.Flyweight
{
    public class ProgramFlyweight
    {
        static void Main(string[] args)
        {
            FlyweightFactory factory = new FlyweightFactory();

            IFlyweight flyweight1 = factory.GetFlyweight("SharedState1");
            flyweight1.Operation(1);

            IFlyweight flyweight2 = factory.GetFlyweight("SharedState2");
            flyweight2.Operation(2);

            IFlyweight flyweight3 = factory.GetFlyweight("SharedState1");
            flyweight3.Operation(3);
        }
    }
}
