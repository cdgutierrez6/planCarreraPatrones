using Patrones.Structural.ProxyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Structural.ProxyPattern
{
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public Proxy()
        {
            _realSubject = new RealSubject();
        }

        public void Request()
        {
            Console.WriteLine("Proxy handles the request and delegates to RealSubject");
            _realSubject.Request();
        }
    }
}
