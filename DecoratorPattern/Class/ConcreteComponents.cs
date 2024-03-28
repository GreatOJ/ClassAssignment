namespace DecoratorPattern.Class;

using DecoratorPattern.Interface;

public class ConcreteComponent : IComponent<string>
{
    public string GetText()
    {
        return "Good morning.";
    }
}