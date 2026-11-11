namespace FactoryExample;

// Concrete product
public class EcoBread : Bread
{
    public override string GetDescription()
    {
        return "Eco bread";
    }
}