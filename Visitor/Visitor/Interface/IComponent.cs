namespace Patrones.Behavior.Visitor.Interface
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
