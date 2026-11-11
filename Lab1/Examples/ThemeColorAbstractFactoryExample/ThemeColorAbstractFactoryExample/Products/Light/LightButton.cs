namespace ThemeColorAbstractFactoryExample.Products.Light;

// Concrete product from the light theme family
public class LightButton : Button
{
    public override void Render()
    {
        Console.WriteLine("Rendering a light button.");
    }
}