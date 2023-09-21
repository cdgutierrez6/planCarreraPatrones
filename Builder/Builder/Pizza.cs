// Clase Pizza que representa el producto final
public class Pizza
{
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public string Topping { get; set; }

    public void Display()
    {
        Console.WriteLine($"Pizza: {Dough}, {Sauce}, {Topping}");
    }
}


