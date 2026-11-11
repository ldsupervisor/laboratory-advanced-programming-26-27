using System;

namespace ThemeColorAbstractFactoryExample.Products.Light;

// Concrete product from the light theme family
public class LightTextBox : TextBox
{
    public override void Render()
    {
        Console.WriteLine("Rendering a light text box.");
    }
}