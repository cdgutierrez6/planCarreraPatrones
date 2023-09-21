using Patrones.Behavior.Interpreter.Interface;

namespace Patrones.Behavior.Interpreter
{
    public class ProgramInterpreter
    {
        static void Main(string[] args)
        {
            // Crear un contexto con valores
            Dictionary<string, int> context = new Dictionary<string, int>();
            context["x"] = 10;
            context["y"] = 5;

            // Crear las expresiones
            IExpression expression = new AddExpression(new NumberExpression(context["x"]), new NumberExpression(context["y"]));

            // Interpretar la expresión
            int result = expression.Interpret(context);
            Console.WriteLine("Resultado: " + result); // Resultado: 15
        }
    }
}