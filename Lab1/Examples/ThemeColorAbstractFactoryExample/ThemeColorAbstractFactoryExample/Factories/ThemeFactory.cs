using ThemeColorAbstractFactoryExample.Products;

namespace ThemeColorAbstractFactoryExample.Factories;

// Abstract factory for a family of matching products
public abstract class ThemeFactory
{
    public abstract Button CreateButton();
    public abstract TextBox CreateTextBox();
}