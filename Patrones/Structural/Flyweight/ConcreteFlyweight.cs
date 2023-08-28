using Patrones.Structural.Flyweight.Interface;

namespace Patrones.Structural.Flyweight
{
    public class ConcreteFlyweight : IFlyweight
    {
        private string _intrinsicState;

        public ConcreteFlyweight(string intrinsicState)
        {
            _intrinsicState = intrinsicState;
        }

        public void Operation(int extrinsicState)
        {
            Console.WriteLine($"Concrete Flyweight: Intrinsic State = {_intrinsicState}, Extrinsic State = {extrinsicState}");
        }
    }
}
