using abstract_factory_pattern.factory;

namespace abstract_factory_pattern;

public static class EnvironmentSelector
{
    public static IGUIFactory SelectEnvironment(string environment)
    {
        if (environment == "Windows")
        {
            return new WindowsGuiFactory();
        }
        else if (environment == "Mac")
        {
            return new MacGuiFactory();
        }
        else
        {
            throw new Exception("Unknown environment!");
        }
    }
}