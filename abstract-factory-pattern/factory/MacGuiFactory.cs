using abstract_factory_pattern.button;
using abstract_factory_pattern.checkbox;

namespace abstract_factory_pattern.factory;

public class MacGuiFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacCheckbox();
    }
}