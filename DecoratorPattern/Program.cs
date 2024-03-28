using DecoratorPattern.Class;
using DecoratorPattern.Interface;

IComponent<string> concreteComponent = new ConcreteComponent();

ColorDecorator colorDecorator = new ColorDecorator(concreteComponent);

PlainDecorator plainDecorator = new PlainDecorator(concreteComponent);

UpperCaseDecorator UpperCaseDecorator = new UpperCaseDecorator(concreteComponent);

Console.WriteLine(concreteComponent.GetText());

Console.WriteLine(colorDecorator.GetText());

Console.WriteLine(plainDecorator.GetText());

Console.WriteLine(UpperCaseDecorator.GetText());