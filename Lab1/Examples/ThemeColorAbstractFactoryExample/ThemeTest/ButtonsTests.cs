using ThemeColorAbstractFactoryExample.Factories;
using ThemeColorAbstractFactoryExample.Products;
using ThemeColorAbstractFactoryExample.Products.Dark;
using ThemeColorAbstractFactoryExample.Products.Light;

namespace ThemeColorAbstractFactoryExample.Tests;

[TestClass]
public class ThemeFactoryTests
{
    [TestMethod]
    public void DarkThemeFactory_CreatesDarkButton()
    {
        // Arrange
        ThemeFactory factory = new DarkThemeFactory();

        // Act
        Button button = factory.CreateButton();

        // Assert
        Assert.IsInstanceOfType(button, typeof(DarkButton));
    }

    [TestMethod]
    public void DarkThemeFactory_CreatesDarkTextBox()
    {
        // Arrange
        ThemeFactory factory = new DarkThemeFactory();

        // Act
        TextBox textBox = factory.CreateTextBox();

        // Assert
        Assert.IsInstanceOfType(textBox, typeof(DarkTextBox));
    }

    [TestMethod]
    public void LightThemeFactory_CreatesLightButton()
    {
        // Arrange
        ThemeFactory factory = new LightThemeFactory();

        // Act
        Button button = factory.CreateButton();

        // Assert
        Assert.IsInstanceOfType(button, typeof(LightButton));
    }

    [TestMethod]
    public void LightThemeFactory_CreatesLightTextBox()
    {
        // Arrange
        ThemeFactory factory = new LightThemeFactory();

        // Act
        TextBox textBox = factory.CreateTextBox();

        // Assert
        Assert.IsInstanceOfType(textBox, typeof(LightTextBox));
    }
}