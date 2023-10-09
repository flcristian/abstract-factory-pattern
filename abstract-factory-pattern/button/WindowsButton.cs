namespace abstract_factory_pattern.button;

public class WindowsButton : IButton
{
    public void Display()
    {
        Console.WriteLine("I am a Windows button!");
    }
}