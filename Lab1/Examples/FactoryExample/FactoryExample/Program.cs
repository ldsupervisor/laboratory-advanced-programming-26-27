using FactoryExample;

Market localMarket = new LocalMarket();
Console.WriteLine(localMarket.SellBread());

Market ecoMarket = new EcoMarket();
Console.WriteLine(ecoMarket.SellBread());