// Constructor de Pizza Margarita
public class MargaritaBuilder : IPizzaBuilder
{
    private Pizza pizza = new Pizza();

    public void BuildDough()
    {
        pizza.Dough = "Masa delgada";
    }

    public void BuildSauce()
    {
        pizza.Sauce = "Tomate";
    }

    public void BuildTopping()
    {
        pizza.Topping = "Queso Mozzarella y Albahaca";
    }

    public Pizza GetPizza()
    {
        return pizza;
    }
}
