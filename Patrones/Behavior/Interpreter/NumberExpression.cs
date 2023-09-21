using Patrones.Behavior.Interpreter.Interface;

namespace Patrones.Behavior.Interpreter
{
    public class NumberExpression : IExpression
    {
        private int value;

        public NumberExpression(int value)
        {
            this.value = value;
        }

        public int Interpret(Dictionary<string, int> context)
        {
            return value;
        }
    }
}
