namespace DesignPatterns.Structural.Decorator;

public static class DecoratorClient
{
    private const bool EnableTelegramNotifier = true;
    private const bool EnableEmailNotifier = true;

    public static void Execute()
    {
        INotifier notifier = new ConsoleNotifier();
        if (EnableTelegramNotifier)
        {
            notifier = new TelegramNotifierDecorator(notifier);
        }

        if (EnableEmailNotifier)
        {
            notifier = new EmailNotifierDecorator(notifier);
        }

        notifier.Notify("Hello, world!");
    }
}