namespace FactoryExample;

// Concrete product
public class LocalBread : Bread
{
    public override string GetDescription()
    {
        return "Local bread";
    }
}