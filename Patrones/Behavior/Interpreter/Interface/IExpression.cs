namespace Patrones.Behavior.Interpreter.Interface
{
    public interface IExpression
    {
        int Interpret(Dictionary<string, int> context);
    }
}
