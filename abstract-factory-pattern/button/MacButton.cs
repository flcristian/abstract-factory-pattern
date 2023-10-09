namespace abstract_factory_pattern.button;

public class MacButton : IButton
{
    public void Display()
    {
        Console.WriteLine("I am a Mac button!");
    }
}