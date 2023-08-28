using Patrones.Structural.ProxyPattern.Interface;

namespace Patrones.Structural.ProxyPattern
{
    public class ProgramProxy
    {
        static void Main(string[] args)
        {
            ISubject subject = new Proxy();

            Console.WriteLine("Client calls the Proxy:");
            subject.Request();
        }
    }
}
