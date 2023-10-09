namespace abstract_factory_pattern.checkbox;

public class MacCheckbox : ICheckbox
{
    public void Display()
    {
        Console.WriteLine("I am a Mac checkbox!");
    }
}