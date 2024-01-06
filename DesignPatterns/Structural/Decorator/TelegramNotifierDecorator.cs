namespace DesignPatterns.Structural.Decorator;

public class TelegramNotifierDecorator : Decorator
{
    public TelegramNotifierDecorator(INotifier notifier) : base(notifier)
    {
    }
    
    public override void Notify(string value)
    {
        Console.WriteLine($"{nameof(TelegramNotifierDecorator)} send notify: {value}!");
        base.Notify(value);
    }
}