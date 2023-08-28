using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Structural.AdapterPattern
{
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee's Specific Request");
        }
    }
}
