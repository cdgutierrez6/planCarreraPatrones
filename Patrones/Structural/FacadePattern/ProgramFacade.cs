namespace Patrones.Structural.FacadePattern
{
    public class ProgramFacade
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            Console.WriteLine("Client uses the Facade to perform operations:");
            facade.Operation1();
            facade.Operation2();
        }
    }
}
