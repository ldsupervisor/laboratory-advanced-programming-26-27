namespace FactoryExample;
// Concrete creator
public class EcoMarket : Market
{
    public override Bread CreateBread()
    {
        return new EcoBread();
    }
}