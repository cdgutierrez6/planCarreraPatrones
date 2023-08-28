using Patrones.Structural.Bridge.Interface;

namespace Patrones.Structural.Bridge.Abstracts
{
    public abstract class Abstraction
    {
        protected IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            _implementation = implementation;
        }

        public abstract void Operation();
    }
}
