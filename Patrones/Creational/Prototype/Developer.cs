// Clase concreta Developer que hereda de Employee
public class Developer : Employee
{
    public string Language { get; set; }

    public override object Clone()
    {
        return MemberwiseClone(); // Clonación superficial, solo se copian los campos primitivos.
    }
}