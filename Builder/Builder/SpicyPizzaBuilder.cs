// Constructor de Pizza Picante
public class SpicyPizzaBuilder : IPizzaBuilder
{
    private Pizza pizza = new Pizza();

    public void BuildDough()
    {
        pizza.Dough = "Masa gruesa";
    }

    public void BuildSauce()
    {
        pizza.Sauce = "Salsa de tomate picante";
    }

    public void BuildTopping()
    {
        pizza.Topping = "Pepperoni, Jalapeños y Queso Mozzarella";
    }

    public Pizza GetPizza()
    {
        return pizza;
    }
}