namespace DesignPatterns.Structural.Decorator;

public class ConsoleNotifier : INotifier
{
    public void Notify(string value)
    {
        Console.WriteLine($"{nameof(ConsoleNotifier)} notify: {value}!");
    }
}