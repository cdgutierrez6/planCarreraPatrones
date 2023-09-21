using Patrones.Behavior.StatePattern;

namespace StatePattern
{
    public class ProgramState
    {
        static void Main(string[] args)
        {
            // The client code.
            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();
        }
    }
}
