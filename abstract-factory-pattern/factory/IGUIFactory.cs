using abstract_factory_pattern.button;
using abstract_factory_pattern.checkbox;

namespace abstract_factory_pattern.factory;

public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}