namespace DecoratorPattern.Class;

using DecoratorPattern.Interface;

public class PlainDecorator : Decorator<string>
{
    public PlainDecorator(IComponent<string> component)
    : base(component)
    {

    }



    public override string GetText()
    {
        return "Hello." + base.GetText();
    }
}