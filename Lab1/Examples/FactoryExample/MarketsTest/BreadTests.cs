using FactoryExample;
namespace MarketTest;

[TestClass]
public class MarketTests
{
    [TestMethod]
    public void LocalMarket_CreatesLocalBread()
    {
        // Arrange
        Market market = new LocalMarket();

        // Act
        Bread bread = market.CreateBread();

        // Assert
        Assert.IsInstanceOfType(bread, typeof(LocalBread));
    }

    [TestMethod]
    public void EcoMarket_CreatesEcoBread()
    {
        // Arrange
        Market market = new EcoMarket();

        // Act
        Bread bread = market.CreateBread();

        // Assert
        Assert.IsInstanceOfType(bread, typeof(EcoBread));
    }

    [TestMethod]
    public void LocalMarket_SellsLocalBread()
    {
        // Arrange
        Market market = new LocalMarket();

        // Act
        string result = market.SellBread();

        // Assert
        Assert.AreEqual("Selling: Local bread", result);
    }

    [TestMethod]
    public void EcoMarket_SellsEcoBread()
    {
        // Arrange
        Market market = new EcoMarket();

        // Act
        string result = market.SellBread();

        // Assert
        Assert.AreEqual("Selling: Eco bread", result);
    }
}