using ThemeColorAbstractFactoryExample.Factories;
using ThemeColorAbstractFactoryExample.Products;

namespace ThemeColorAbstractFactoryExample.Clients;

// Client: depends only on the factory and product abstractions
public class Screen
{
    private readonly Button _button;
    private readonly TextBox _textBox;

    public Screen(ThemeFactory factory)
    {
        _button = factory.CreateButton();
        _textBox = factory.CreateTextBox();
    }

    public void Render()
    {
        _button.Render();
        _textBox.Render();
    }
}