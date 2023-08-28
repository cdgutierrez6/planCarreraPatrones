namespace Patrones.Structural.CompositePattern.Abstracts
{
    public abstract class Component
    {
        protected string _name;

        public Component(string name)
        {
            _name = name;
        }

        public abstract void Display(int depth);
    }
}
