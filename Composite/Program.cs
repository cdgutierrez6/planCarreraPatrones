namespace Patrones.Structural.CompositePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("Root");    
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            root.Display(1);

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            
            root.Display(1);

            root.Add(new Leaf("Leaf C"));


            Composite comp2 = new Composite("Composite Y");
            comp2.Add(new Leaf("Leaf YA"));
            comp2.Add(new Leaf("Leaf YB"));
            comp2.Add(comp);

            root.Add(comp2);


            root.Display(1);

            comp2.Remove(comp);

            root.Display(1);

            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            
            root.Display(1);
        }
    }
}
