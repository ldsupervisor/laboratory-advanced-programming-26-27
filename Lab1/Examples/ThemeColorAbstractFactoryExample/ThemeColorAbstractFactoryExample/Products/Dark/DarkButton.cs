namespace ThemeColorAbstractFactoryExample.Products.Dark;

// Concrete product from the dark theme family
public class DarkButton : Button
{
    public override void Render()
    {
        Console.WriteLine("Rendering a dark button.");
    }
}