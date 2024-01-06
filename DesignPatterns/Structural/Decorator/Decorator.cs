namespace DesignPatterns.Structural.Decorator;

public class Decorator : INotifier
{
    private readonly INotifier _notifier;

    public Decorator(INotifier notifier)
    {
        _notifier = notifier;
    }

    public virtual void Notify(string value)
    {
        _notifier.Notify(value);
    }
}