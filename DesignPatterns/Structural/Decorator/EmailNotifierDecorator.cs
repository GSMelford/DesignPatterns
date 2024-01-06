namespace DesignPatterns.Structural.Decorator;

public class EmailNotifierDecorator : Decorator
{
    public EmailNotifierDecorator(INotifier notifier) : base(notifier)
    {
    }

    public override void Notify(string value)
    {
        Console.WriteLine($"{nameof(EmailNotifierDecorator)} send notify: {value}!");
        base.Notify(value);
    }
}