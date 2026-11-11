namespace FactoryExample;

// Creator
public abstract class Market
{
    // Factory Method: subclasses choose the concrete product.
    public abstract Bread CreateBread();

    // Shared operation that uses the Factory Method.
    public string SellBread()
    {
        Bread bread = CreateBread();

        return $"Selling: {bread.GetDescription()}";
    }
}