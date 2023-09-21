// Fábrica concreta para Laptops
public class LaptopFactory : IElectronicFactory
{
    public IElectronicProduct CreateProduct()
    {
        return new Laptop();
    }
}