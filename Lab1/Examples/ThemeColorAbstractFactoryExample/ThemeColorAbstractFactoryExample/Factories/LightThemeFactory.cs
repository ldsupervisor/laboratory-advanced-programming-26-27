using ThemeColorAbstractFactoryExample.Products;
using ThemeColorAbstractFactoryExample.Products.Light;

namespace ThemeColorAbstractFactoryExample.Factories;

// Creates products from the light theme family
public class LightThemeFactory : ThemeFactory
{
    public override Button CreateButton()
    {
        return new LightButton();
    }

    public override TextBox CreateTextBox()
    {
        return new LightTextBox();
    }
}