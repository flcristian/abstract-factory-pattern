namespace abstract_factory_pattern.checkbox;

public class WindowsCheckbox : ICheckbox
{
    public void Display()
    {
        Console.WriteLine("I am a Windows checkbox!");
    }
}