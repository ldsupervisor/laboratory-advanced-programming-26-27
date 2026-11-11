namespace ThemeColorAbstractFactoryExample.Products.Dark;

public class DarkTextBox : TextBox
{
    public override void Render()
    {
        Console.WriteLine("Rendering a dark text box.");
    }
}