// Director
public class PizzaDirector
{
    private IPizzaBuilder pizzaBuilder;

    public PizzaDirector(IPizzaBuilder builder)
    {
        pizzaBuilder = builder;
    }

    public void MakePizza()
    {
        pizzaBuilder.BuildDough();
        pizzaBuilder.BuildSauce();
        pizzaBuilder.BuildTopping();
    }

    public Pizza GetPizza()
    {
        return pizzaBuilder.GetPizza();
    }
}
