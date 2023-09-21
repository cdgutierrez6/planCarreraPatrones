// Clase base Employee que implementa ICloneable
public abstract class Employee : ICloneable
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Id { get; set; }

    public abstract object Clone();
}
