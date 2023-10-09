using abstract_factory_pattern.button;
using abstract_factory_pattern.checkbox;

namespace abstract_factory_pattern.factory;

public class WindowsGuiFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WindowsCheckbox();
    }
}