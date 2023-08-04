// Clase concreta Manager que hereda de Employee
public class Manager : Employee
{
    public string Department { get; set; }

    public override object Clone()
    {
        return MemberwiseClone(); // Clonación superficial, solo se copian los campos primitivos.
    }
}