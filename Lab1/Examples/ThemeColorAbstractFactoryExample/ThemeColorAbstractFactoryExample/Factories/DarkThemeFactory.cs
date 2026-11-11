using ThemeColorAbstractFactoryExample.Products;
using ThemeColorAbstractFactoryExample.Products.Dark;

namespace ThemeColorAbstractFactoryExample.Factories;

// Creates products from the dark theme family
public class DarkThemeFactory : ThemeFactory
{
    public override Button CreateButton()
    {
        return new DarkButton();
    }

    public override TextBox CreateTextBox()
    {
        return new DarkTextBox();
    }
}