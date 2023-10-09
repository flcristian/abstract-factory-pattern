using abstract_factory_pattern;
using abstract_factory_pattern.button;
using abstract_factory_pattern.checkbox;
using abstract_factory_pattern.factory;

internal class Program
{
    public static void Main(string[] args)
    {
        IGUIFactory factory = EnvironmentSelector.SelectEnvironment("Windows");
        IButton button = factory.CreateButton();
        ICheckbox checkbox = factory.CreateCheckbox();
        
        button.Display();
        checkbox.Display();
    }
}