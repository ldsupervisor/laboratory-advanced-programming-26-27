using ThemeColorAbstractFactoryExample.Clients;
using ThemeColorAbstractFactoryExample.Factories;

// Select the dark theme family.
ThemeFactory factory = new DarkThemeFactory();

Screen screen = new Screen(factory);
screen.Render();

Console.WriteLine();

// Select the light theme family.
factory = new LightThemeFactory();

Screen lightScreen = new Screen(factory);
lightScreen.Render();