namespace FactoryExample;

// Concrete creator
public class LocalMarket : Market
{
    public override Bread CreateBread()
    {
        return new LocalBread();
    }
}