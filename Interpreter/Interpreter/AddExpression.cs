using Patrones.Behavior.Interpreter.Interface;

namespace Patrones.Behavior.Interpreter
{
    public class AddExpression : IExpression
    {
        private IExpression leftOperand;
        private IExpression rightOperand;

        public AddExpression(IExpression leftOperand, IExpression rightOperand)
        {
            this.leftOperand = leftOperand;
            this.rightOperand = rightOperand;
        }

        public int Interpret(Dictionary<string, int> context)
        {
            return leftOperand.Interpret(context) + rightOperand.Interpret(context);
        }
    }
}
