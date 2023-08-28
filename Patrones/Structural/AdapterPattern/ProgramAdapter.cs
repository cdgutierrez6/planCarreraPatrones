using Patrones.Structural.AdapterPattern.Interface;

namespace Patrones.Structural.AdapterPattern
{
    internal class ProgramAdapter
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            target.Request();
        }
    }
}
