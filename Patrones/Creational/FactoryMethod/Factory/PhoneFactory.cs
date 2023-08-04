// Fábrica concreta para Teléfonos
public class PhoneFactory : IElectronicFactory
{
    public IElectronicProduct CreateProduct()
    {
        return new Phone();
    }
}