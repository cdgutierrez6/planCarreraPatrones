using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ProgramBuilder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creando una pizza Margarita:");
            IPizzaBuilder margaritaBuilder = new MargaritaBuilder();
            PizzaDirector margaritaDirector = new PizzaDirector(margaritaBuilder);
            margaritaDirector.MakePizza();
            Pizza margaritaPizza = margaritaDirector.GetPizza();
            margaritaPizza.Display();

            Console.WriteLine();

            Console.WriteLine("Creando una pizza Picante:");
            IPizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();
            PizzaDirector spicyPizzaDirector = new PizzaDirector(spicyPizzaBuilder);
            spicyPizzaDirector.MakePizza();
            Pizza spicyPizza = spicyPizzaDirector.GetPizza();
            spicyPizza.Display();
        }
    }
}
