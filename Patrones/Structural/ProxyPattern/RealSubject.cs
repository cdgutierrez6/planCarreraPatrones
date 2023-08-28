using Patrones.Structural.ProxyPattern.Interface;

namespace Patrones.Structural.ProxyPattern
{
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject handles the request");
        }
    }
}
