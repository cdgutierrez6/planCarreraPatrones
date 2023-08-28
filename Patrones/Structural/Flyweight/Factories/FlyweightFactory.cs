using Patrones.Structural.Flyweight.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Structural.Flyweight.Factories
{
    public class FlyweightFactory
    {
        private Dictionary<string, IFlyweight> _flyweights = new Dictionary<string, IFlyweight>();

        public IFlyweight GetFlyweight(string key)
        {
            if (!_flyweights.ContainsKey(key))
            {
                _flyweights[key] = new ConcreteFlyweight(key);
            }
            return _flyweights[key];
        }
    }
}
